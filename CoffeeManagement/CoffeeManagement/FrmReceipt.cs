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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

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
                    order.createdDate.ToLower().Contains(searchText)// Add other fields as necessary
                ).ToList();

                dgvReceipt.DataSource = filteredOrders;
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
            //// Kiểm tra nếu người dùng click vào một hàng hợp lệ
            //if (e.RowIndex >= 0)
            //{
            //    // Lấy dữ liệu từ hàng được click
            //    var selectedRow = dgvReceipt.Rows[e.RowIndex];
            //    string cellValue = selectedRow.Cells[0].Value.ToString(); // Lấy giá trị của ô đầu tiên

            //    // Thực hiện hành động bạn muốn với dữ liệu
            //    MessageBox.Show($"Bạn đã click vào hàng: {cellValue}");
            //}
        }
        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();

            //List<String> names = new List<String>() { "Id", "Username", "Password", "Role", "FullName", "Sex", "DateOfBirth", "Address", "PhoneNumber", "DateOfRegistration" };

            //for (int i = 0; i < names.Count; i++)
            //{
            //    dgv.Columns[i].Name = names[i];
            //    dgv.Columns[i].DataPropertyName = names[i];
            //}



            DataGridViewImageColumn detailColumn = new DataGridViewImageColumn
            {
                Name = "Detail",
                Image = Properties.Resources.cat_delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvReceipt.Columns.Add(detailColumn);



            return dgv;
        }

    }
}
