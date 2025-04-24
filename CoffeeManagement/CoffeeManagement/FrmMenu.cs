using BusinessLayer;
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
        //List<Item> items = new List<Item>();
        List<CartSlot> items = new List<CartSlot>();

        public void AddItem(Product product)
        {
            if (items != null)
            {
                // Kiểm tra xem sản phẩm đã tồn tại trong giỏ hàng chưa
                var existingItem = items.FirstOrDefault(i => i.product.id == product.id);
                if (existingItem != null)
                {
                    // Nếu sản phẩm đã tồn tại, tăng số lượng
                    existingItem.quantity++;
                }
                else
                {
                    // Nếu sản phẩm chưa tồn tại, thêm mới vào giỏ hàng
                    items.Add(new CartSlot(product, 1));
                }
            }
            else
            {
                items.Add(new CartSlot(product, 1));
                //items.Add(item);
                // Add item to cart or perform any other action
            }
        }
        public FrmMenu()
        {
            InitializeComponent();
            categoryBL = new CategoryBL();
            productBL = new ProductBL();
            Observer.Register(this);
        }

        public void OnNotify(string key)
        {
            if (key == "UpdateProdItems")
            {
                UpdateProdItems();
            }
        }

        private void UpdateProdItems()
        {
            pnProdItems.Controls.Clear(); // Xóa các sản phẩm cũ trong panel
            foreach (var item in items)
            {
                USCartItem us = new USCartItem();
                us.CartSlotInit(item);
                us.Dock = DockStyle.Top; // Căn chỉnh control sản phẩm theo chiều dọc
               

                pnProdItems.Controls.Add(us);
            }
        }
        private void FrmMenu_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Category clicked: " + category.name);
                });
            }
            //////////////////////////////////////////////////////////////////////////////////////
            //load product
            List<Product> prods = new List<Product>();
            prods = productBL.GetProducts();
            pnProduct.Controls.Clear(); 
            foreach (var product in prods)
            {
                USProdItem us = new USProdItem();
                us.ProductInit(product);      
                //us.Dock = DockStyle.Left; // Căn chỉnh control sản phẩm theo chiều dọc
                pnProduct.Controls.Add(us);

            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string message = "Items:\n";

            foreach(CartSlot item in items)
            {
                message += item.product.name + " - " + item.quantity+ "\n";
            }
            MessageBox.Show(message);
        }
    }
}
