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
    public partial class FrmOrderInfo : Form
    {
        ItemBL itemBL;
        OrderBL orderBL;

        Order order;
        List<Item> items;
        public FrmOrderInfo(int id)
        {

            InitializeComponent();
            orderBL = new OrderBL();
            itemBL = new ItemBL();
            items = new List<Item>();
            this.order = orderBL.GetOrderByID(id);
        }
        private void LoadOrder() { }

        private void FrmOrderInfo_Load(object sender, EventArgs e)
        {

            lbPaymentMethod.Text = order.paymentMethod;
            lbStaff.Text = order.accountID.ToString();
            lbCoupon.Text = order.couponID;
            lbCreateDate.Text = order.createdDate;
            lbTotalPrice.Text = order.totalPrice.ToString();
            lbcounterFeit.Text = order.counterfeit.ToString();
            try
            {
                items = itemBL.GetItemByOrderID(order.id);
                dgvItems.DataSource = items;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
