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
        float totalPrice = 0;



        public FrmCartInfo(List<CartSlot> cartSlots, float totalPrice)
        {
            InitializeComponent();
            orderBL = new OrderBL();
            ItemBL = new ItemBL();
            this.cartSlots = cartSlots;
            this.totalPrice = totalPrice;
            PoadPaymentMethod();
        }
        private void PoadPaymentMethod()
        {
            cbPaymentMethod.Items.Clear();

            Array payment = Enum.GetValues(typeof(CONSTANT.paymentMethod));
            foreach (var a in payment)
            {
                cbPaymentMethod.Items.Add(a.ToString());
            }
            cbPaymentMethod.SelectedIndex = 0;
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
            lbTotalPrice.Text = totalPrice.ToString();
            lbLastTotalPrice.Text = totalPrice.ToString();

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
            if (Counterfeit < totalPrice )
            {
                DialogResult result = MessageBox.Show("so tien thanh toan khong du", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtCounterfeit.Clear();
                txtCounterfeit.Focus();
                return;
            }
            try
            {
                Order order = new Order(totalPrice, Counterfeit, cbPaymentMethod.Text, Form1.Instance.account.id);

                int newOrderId = orderBL.AddOrder(order);
                foreach (var slot in cartSlots)
                {
                    Item item = new Item(1, newOrderId, slot.product.id, slot.Quantity, slot.totalPrice);
                    ItemBL.AddItem(item);
                }
                Observer.Notify(CONSTANT.ActionAfterCheckout);
                MessageBox.Show("Thanh toán thành công!");
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
            
        }

    }
}
