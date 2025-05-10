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
        CouponBL couponBL;
        Order order;
        List<Item> items;
        public FrmOrderInfo(int id)
        {

            InitializeComponent();
            orderBL = new OrderBL();
            itemBL = new ItemBL();
            items = new List<Item>();
            couponBL = new CouponBL();
            this.order = orderBL.GetOrderByID(id);
            
        }
        private void LoadOrder() { }

        private void FrmOrderInfo_Load(object sender, EventArgs e)
        {
            Coupon coupon = new Coupon();
            coupon = couponBL.GetCoupons().Where(coupon => coupon.id == order.couponID).FirstOrDefault();
            lbPaymentMethod.Text = order.paymentMethod;
            if(coupon == null)
            {
                coupon = new Coupon();
                coupon.value = 0;
            }
            lbLastTotal.Text = (order.totalPrice-coupon.value).ToString("#,0" + " VNĐ");
            lbStaff.Text = order.accountID.ToString();
            lbCoupon.Text = coupon.id+"-"+ coupon.description;
            lbCreateDate.Text = order.createdDate.ToString("dd/MM/yyyy");
            lbTotalPrice.Text = order.totalPrice.ToString("#,0"+" VNĐ");
            lbcounterFeit.Text = order.counterfeit.ToString("#,0" + " VNĐ");
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
