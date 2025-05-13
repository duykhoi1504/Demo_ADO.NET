using BusinessLayer;
using CoffeeManagement;
using DataLayer;
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
        OrderBL orderBL;
        ItemBL itemBL;
        List<Product> prods;
        float totalPrice = 0;

        public List<CartSlot> cartSlots = new List<CartSlot>();
        public FrmMenu()
        {
            InitializeComponent();
            categoryBL = new CategoryBL();
            productBL = new ProductBL();
            itemBL = new ItemBL();
            orderBL = new OrderBL();

            // Đăng ký observer cho FrmMenu
            Observer.Register(this);
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LoadCatogery();
            LoadProduct();

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



        private void LoadCatogery()
        {
            //load category
            List<Category> cats = new List<Category>();
            cats = categoryBL.GetCategories();
            foreach (var category in cats)
            {
                Button button = new Button();
                button.Text = category.name;
                button.BackColor = Color.White;
                button.ForeColor = Color.DarkGreen;
                button.Dock = DockStyle.Left; // Că n chỉnh button theo chiều dọc
                pnFilter.Controls.Add(button);

                ////button event
                button.Click += ((s, e) =>
                {
                    // Xử lý sự kiện khi nhấn nút category
                    // Ví dụ: lọc sản phẩm theo category
                    LoadProduct(category.id.ToString());
                });
            }
            ///////////////////////////////////////////////////////////////
            Button all = new Button();
            all.Text = "Show All";
            all.BackColor = Color.White;
            all.ForeColor = Color.DarkGreen;
            all.Dock = DockStyle.Left; // Că n chỉnh button theo chiều dọc
            all.Click += ((s, e) =>
            {
                LoadProduct();
            });
            pnFilter.Controls.Add(all);
            //pnFilte
        }
        private void LoadProduct(string key = null)
        {
            if (prods == null)
            {
                prods = new List<Product>();
            }
            prods.Clear();
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
            if(cartSlots.Count <= 0)
            {
                MessageBox.Show("Your cart is empty");
                return;
            }
            UpdateProdCart();

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
            btnTotal.Text = "Total Price: " + totalPrice.ToString("#,0") + " VND";
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


        private void ActionAfterCheckout()
        {
            cartSlots.Clear(); // Xóa giỏ hàng sau khi thanh toán
            pnProdItems.Controls.Clear(); // Xóa các sản phẩm cũ trong panel
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if(prods==null)
            //{
            //    return;
            //}
            //prods.Where(p => p.name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            //LoadProduct();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            pnProduct.Controls.Clear(); // Xóa các sản phẩm cũ trong panel
            List<Product> prods2 = productBL.GetProducts();
            var filteredProducts = prods2
           .Where(p => p.name.ToLower().Contains(txtSearch.Text.ToLower()))
           .ToList();
            //string m = "";
            //foreach (var prod in filteredProducts)
            //{
            //    m += prod.name + " \n";
            //}
            //MessageBox.Show(m);
            foreach (var prod in filteredProducts)
            {

                USProdItem us = new USProdItem();
                us.ProductInit(prod);
                //us.Dock = DockStyle.Left; // Căn chỉnh control sản phẩm theo chiều dọc
                pnProduct.Controls.Add(us);
            }

        }
    }

}