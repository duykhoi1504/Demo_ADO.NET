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
        List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
            // Add item to cart or perform any other action
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
                us.SetCartInfo(item.id, item.orderID);
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
                button.Dock = DockStyle.Left; // Căn chỉnh button theo chiều dọc



                pnFilter.Controls.Add(button);
            }
            //load product
            List<Product> prods = new List<Product>();
            prods = productBL.GetProducts();
            pnProduct.Controls.Clear(); 
            foreach (var product in prods)
            {
                USProdItem us = new USProdItem();
                us.SetProdInfo(product.name, product.price.ToString(), null);
                //us.Dock = DockStyle.Left; // Căn chỉnh control sản phẩm theo chiều dọc
                pnProduct.Controls.Add(us);

            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total: " + items.Count);
        }
    }
}
