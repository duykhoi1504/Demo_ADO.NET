using BusinessLayer;
using CoffeeManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;



namespace PresentationLayer
{

    public partial class FrmMenu : Form, IObserver
    {
        CategoryBL categoryBL;
        ProductBL productBL;
        float totalPrice = 0;

        public List<CartSlot> cartSlots = new List<CartSlot>();
        public FrmMenu()
        {
            InitializeComponent();
            categoryBL = new CategoryBL();
            productBL = new ProductBL();

     // Đăng ký observer cho FrmMenu
            Observer.Register(this);
        }

        public void AddItem(Product product)
        {
            // Kiểm tra và khởi tạo cartSlots nếu cần
            if (cartSlots == null)
            {
                cartSlots = new List<CartSlot>();
            }

            // Kiểm tra xem sản phẩm đã tồn tại trong giỏ hàng chưa
            foreach (var slot in cartSlots)
            {
                if (slot.product.id == product.id)
                {
                    // Nếu sản phẩm đã tồn tại, tăng số lượng
                    slot.Quantity++;
                    return;
                }
            }

            // Nếu sản phẩm chưa tồn tại, thêm mới vào giỏ hàng
            cartSlots.Add(new CartSlot(product, 1));
        }

        public void RemoveItem(Product product)
        {
            // Kiểm tra xem sản phẩm có trong giỏ hàng không
            foreach (var slot in cartSlots)
            {
                if (slot.product.id == product.id)
                {

                    // Nếu số lượng bằng 0, xóa sản phẩm khỏi giỏ hàng
                    cartSlots.Remove(slot);
                    UpdateProdCart();
                    return;
                }
            }

        }

        private void UpdateProdCart()
        {
            pnProdItems.Controls.Clear(); // Xóa các sản phẩm cũ trong panel
            foreach (var slot in cartSlots)
            {
                USCartItem us = new USCartItem();
                us.CartSlotInit(slot);
                us.Dock = DockStyle.Top; // Căn chỉnh control sản phẩm theo chiều dọc


                pnProdItems.Controls.Add(us);
            }
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LoadCatogery();
            //LoadProduct();

        }


        private void LoadCatogery()
        {
            //load category
            List<Category> cats = new List<Category>();
            cats = categoryBL.GetCategories();
            foreach (var category in cats)
            {
                Button button = new Button();
                button.Text = category.name;
                button.Dock = DockStyle.Left; // Că n chỉnh button theo chiều dọc
                pnFilter.Controls.Add(button);

                ////button event
                button.Click += ((s, e) =>
                {
                    // Xử lý sự kiện khi nhấn nút category
                    // Ví dụ: lọc sản phẩm theo category
                    LoadProduct(category.id.ToString());
                    MessageBox.Show("Category clicked: " + category.name);
                });
            }
            //////////////////////////////////////////////////////////////////////////////////////
        }
        private void LoadProduct(string key = null)
        {

            //load product


            List<Product> prods = new List<Product>();
            prods = productBL.GetProducts();
            pnProduct.Controls.Clear();

            foreach (var product in prods)
            {
                if (key != null)
                {

                    if (key == product.categoryID.ToString())
                    {
                        //if (product.categoryId == category.id)
                        USProdItem us = new USProdItem();
                        us.ProductInit(product);
                        //us.Dock = DockStyle.Left; // Căn chỉnh control sản phẩm theo chiều dọc
                        pnProduct.Controls.Add(us);
                    }
                }
                else
                {
                    USProdItem us = new USProdItem();
                    us.ProductInit(product);
                    //us.Dock = DockStyle.Left; // Căn chỉnh control sản phẩm theo chiều dọc
                    pnProduct.Controls.Add(us);
                }
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //float totalPrice = 0;   
            UpdateProdCart();
            //string message = "Items:\n";

            //foreach (CartSlot slot in cartSlots)
            //{

            //    message += slot.product.name + " - " + slot.Quantity + " - " + slot.totalPrice + "\n";
            //    //totalPrice += slot.totalPrice;
            //}
            //MessageBox.Show(message);
            FrmCartInfo frmCartInfo = new FrmCartInfo(cartSlots, totalPrice);
            frmCartInfo.Show();

        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0;
            foreach (CartSlot slot in cartSlots)
            {
                totalPrice += slot.totalPrice;
            }
            btnTotal.Text = "Total Price: " + totalPrice.ToString();
        }

        public void OnNotify(string key)
        {
            if (key == CONSTANT.UpdateProdCart)
            {
                UpdateProdCart();
            }
            if (key == CONSTANT.UpdateTotalPriceButton)
            {

                UpdateTotalPrice();
            }
            if (key == CONSTANT.ActionAfterCheckout)
            {
                ActionAfterCheckout();
            }
        }

        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void ActionAfterCheckout()
        {
            pnProdItems.Controls.Clear(); // Xóa các sản phẩm cũ trong panel
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Form1.Instance;

            //Form1.Instance.Show();

            string m = $"{mainForm.account.id} + {Form1.Instance.account.id}";
            MessageBox.Show(m);

        }
    }

}
