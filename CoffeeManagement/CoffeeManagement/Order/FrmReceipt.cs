using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmReceipt : Form
    {

        OrderBL orderBL;
        ItemBL itemBL;
        List<Order> orders;
        public FrmReceipt()
        {
            InitializeComponent();
            orderBL = new OrderBL();
            itemBL = new ItemBL();
            orders = orderBL.GetOrders();

        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            CustomDataGridView(dgvReceipt);
            if (orders.Count > 0)
            {
                dgvReceipt.DataSource = orders;
            }
            else
            {
                MessageBox.Show("No orders found.");
            }
        }

       

        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (row >= 0 && col == dgvReceipt.Columns["Detail"].Index)
            {

                // Lấy giá trị của ô "id" từ hàng đã chọn
                int idValue = int.Parse(dgvReceipt.Rows[row].Cells["id"].Value.ToString());
                FrmOrderInfo frmOrderInfo = new FrmOrderInfo(idValue);

                frmOrderInfo.ShowDialog();

            }

        }
        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();
            DataGridViewImageColumn detailColumn = new DataGridViewImageColumn
            {
                Name = "Detail",
                Image = Properties.Resources.cat_write,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvReceipt.Columns.Add(detailColumn);



            return dgv;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Reset to show all orders
                dgvReceipt.DataSource = orders;
            }
            else
            {
                // Filter the orders based on the search text
                var filteredOrders = orders.Where(order =>
                    order.id.ToString().Contains(searchText) ||
                    order.paymentMethod.ToLower().Contains(searchText) ||
                    order.couponID.ToLower().Contains(searchText) ||
                    order.createdDate.ToString().Contains(searchText)// Add other fields as necessary
                ).ToList();

                dgvReceipt.DataSource = filteredOrders;
            }
        }
    }
}
