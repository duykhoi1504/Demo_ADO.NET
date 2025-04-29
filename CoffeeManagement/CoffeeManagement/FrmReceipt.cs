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
                    order.couponID.ToLower().Contains(searchText)||
                    order.createdDate.ToLower().Contains(searchText)// Add other fields as necessary
                ).ToList();

                dgvReceipt.DataSource = filteredOrders;
            }
        }
    }
}
