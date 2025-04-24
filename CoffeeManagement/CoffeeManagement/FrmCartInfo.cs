using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmCartInfo : Form
    {
        List<CartSlot> cartSlots;
        float totalPrice = 0;
        public FrmCartInfo(List<CartSlot> cartSlots, float totalPrice)
        {
            InitializeComponent();
            this.cartSlots = cartSlots;
            this.totalPrice = totalPrice;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCartInfo_Load(object sender, EventArgs e)
        {

            try
            {
                var displayList = cartSlots.Select(slot => new
                {
                    ProductName = slot.product.name,
                    Quantity = slot.Quantity,
                    TotalPrice = slot.totalPrice
                }).ToList();

                dgvCart.DataSource = displayList;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbTotalPrice.Text =  totalPrice.ToString();
            lbLastTotalPrice.Text = totalPrice.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
