using BusinessLayer;
using CoffeeManagement;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmCartInfo : Form
    {
        List<CartSlot> cartSlots;
        OrderBL orderBL;
        ItemBL ItemBL;
        CouponBL couponBL;
        float totalPrice = 0;
        float tempTotalPrice = 0; // Lưu giá trị tổng ban đầu


        public FrmCartInfo(List<CartSlot> cartSlots, float totalPrice)
        {
            InitializeComponent();
            orderBL = new OrderBL();
            ItemBL = new ItemBL();
            couponBL = new CouponBL();
            this.cartSlots = cartSlots;
            this.totalPrice = totalPrice;
            this.tempTotalPrice = totalPrice; // Lưu giá trị tổng ban đầu
            LoadComBoxPaymentMethod();
            LoadComBoxCoupon();
        }
        private void LoadComBoxPaymentMethod()
        {
            cbPaymentMethod.Items.Clear();

            Array payment = Enum.GetValues(typeof(CONSTANT.paymentMethod));
            foreach (var a in payment)
            {
                cbPaymentMethod.Items.Add(a.ToString());
            }
            if (cbPaymentMethod.Items.Count > 0)
            {
                cbPaymentMethod.SelectedIndex = 0; // Chọn item đầu tiên nếu có
            }
        }
        private void LoadComBoxCoupon()
        {
            cbCoupon.Items.Clear();
            var noCoupon = new Coupon("", "Không áp mã", 0);
            List<Coupon> coupons = couponBL.GetCoupons();
            coupons.Insert(0, noCoupon);
            cbCoupon.DataSource = coupons;
            //foreach (var coupon in coupons)
            //{
            //    cbCoupon.Items.Add(coupon);
            //}
            if (cbCoupon.Items.Count > 0)
            {
                cbCoupon.SelectedIndex = -1; // Chọn item đầu tiên nếu có
            }
        }
        private string GetSelectedCouponID()
        {
            if (cbCoupon.SelectedItem is Coupon coupon)
            {

                return coupon.id; // Trả về ID của coupon đã chọn
            }
            return null; // Nếu không có gì được chọn
        }
        private void FrmCartInfo_Load(object sender, EventArgs e)
        {

            try
            {
                var displayList = cartSlots.Select(slot => new
                {
                    ProductName = slot.product.name,
                    ProductPrice = slot.product.price,
                    Quantity = slot.Quantity,
                    TotalPrice = slot.totalPrice
                }).ToList();

                dgvCart.DataSource = displayList;
                dgvCart.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvCart.Columns["ProductPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvCart.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvCart.Columns["TotalPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbTotalPrice.Text = totalPrice.ToString("#,0" + " VNĐ");
            lbLastTotalPrice.Text = totalPrice.ToString("#,0" + " VNĐ");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            float Counterfeit = 0;

            DialogResult checkout = MessageBox.Show("Bạn có chắc chắn thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (checkout != DialogResult.Yes) return;



            // Kiểm tra xem txtCounterfeit có rỗng hay không
            if (string.IsNullOrWhiteSpace(txtCounterfeit.Text))
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
                return; // Kết thúc hàm nếu rỗng
            }

            try
            {
                Counterfeit = float.Parse(txtCounterfeit.Text);
                // Tiến hành xử lý với Counterfeit
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng số không hợp lệ. Vui lòng nhập lại.");
            }
            /////////////////////
            if (Counterfeit < totalPrice)
            {
                DialogResult result = MessageBox.Show("so tien thanh toan khong du", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtCounterfeit.Clear();
                txtCounterfeit.Focus();
                return;
            }
            try
            {
                Order order = new Order(totalPrice, Counterfeit, cbPaymentMethod.Text, GetSelectedCouponID(), Form1.Instance.account.id);

                int newOrderId = orderBL.AddOrder(order);
                //gắn id mới vào order

                foreach (var slot in cartSlots)
                {
                    Item item = new Item(1, newOrderId, slot.product.id, slot.Quantity, slot.totalPrice);
                    ItemBL.AddItem(item);
                }
                Observer.Notify(CONSTANT.ActionAfterCheckout);
                MessageBox.Show("Thanh toán thành công!");
                FrmOrderInfo orderInfo = new FrmOrderInfo(newOrderId);
                orderInfo.Show();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);

            }
            //orderBL.UpdateOrder(order);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCounterfeit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số hoặc phím Backspace không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn nhập ký tự không hợp lệ
            }
            // Kiểm tra xem ký tự đầu tiên có phải là dấu trừ
            if (e.KeyChar == '-' && ((sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true; // Ngăn chặn nhập dấu trừ nếu không phải ở đầu
            }
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPaymentMethod = cbPaymentMethod.SelectedItem.ToString();
            if(selectedPaymentMethod == CONSTANT.paymentMethod.CREDITCARD.ToString())
            {
              btnGenQr.Visible = true;
            }
            else
            {
                btnGenQr.Visible = false;
            }
      
        }

        private void cbCoupon_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrice = tempTotalPrice;
            if (cbCoupon.SelectedItem is Coupon coupon) // Kiểm tra xem có coupon được chọn không
            {

                if (coupon.value > totalPrice) // Kiểm tra giá trị coupon
                {
                    MessageBox.Show("Mã giảm giá không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbCoupon.SelectedIndex = -1; // Đặt lại lựa chọn
                    lbLastTotalPrice.Text = tempTotalPrice.ToString("#,0" + " VNĐ"); // Khôi phục giá trị tổng
                    totalPrice = tempTotalPrice; // Khôi phục giá trị tổng
                    return;
                }

                // Cập nhật giá trị tổng sau khi áp dụng coupon
                float newTotalPrice = totalPrice - coupon.value;
                lbLastTotalPrice.Text = newTotalPrice.ToString("#,0" + " VNĐ");
                totalPrice = newTotalPrice; // Cập nhật giá trị tổng
            }

        }
        private void btnGenQr_Click(object sender, EventArgs e)
        {
            // Hiển thị form thanh toán VietQR
            Payment.FrmVietQr frmVietQr = new Payment.FrmVietQr(totalPrice);
            frmVietQr.ShowDialog();
        }

        private void txtCounterfeit_TextChanged(object sender, EventArgs e)
        {

        }

    }
}