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
    public partial class FrmMenu : Form
    {
        CategoryBL categoryBL;
        ProductBL productBL;
        public FrmMenu()
        {

            InitializeComponent();
            categoryBL = new CategoryBL();
            productBL = new ProductBL();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //load category
            List<Category> cats= new List<Category>();
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
            foreach (var product in prods) { 
            USProdItem us = new USProdItem();
                us.SetProdInfo(product.name, product.price, null);
                //us.Dock = DockStyle.Left; // Căn chỉnh control sản phẩm theo chiều dọc
                pnProduct.Controls.Add(us);
            
            }

            //foreach (var prod in prods)
            //{
            //    // Tạo panel cho từng sản phẩm
            //    Panel productPanel = new Panel();
            //    productPanel.Width = 150; // Chiều rộng của panel sản phẩm
            //    productPanel.Height = 200; // Chiều cao của panel sản phẩm
            //    productPanel.Margin = new Padding(10); // Khoảng cách giữa các panel
            //    productPanel.BackColor = Color.Brown; // Màu nền của panel

            //    // Tạo PictureBox
            //    PictureBox pictureBox = new PictureBox();
            //    pictureBox.Image = null; // Đọc ảnh từ đường dẫn
            //    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Căn chỉnh ảnh
            //    pictureBox.Dock = DockStyle.Fill; // Lấp đầy không gian còn lại của panel

            //    // Tạo Label cho tên sản phẩm
            //    Label labelName = new Label();
            //    labelName.Text = prod.name;
            //    labelName.ForeColor = Color.White; // Màu chữ
            //    labelName.Dock = DockStyle.Top; // Căn chỉnh label ở trên cùng
            //    labelName.TextAlign = ContentAlignment.MiddleCenter; // Căn giữa chữ

            //    // Tạo Label cho giá sản phẩm
            //    Label labelPrice = new Label();
            //    labelPrice.Text = prod.price;
            //    labelPrice.ForeColor = Color.White; // Màu chữ
            //    labelPrice.Dock = DockStyle.Bottom; // Căn chỉnh label ở dưới cùng
            //    labelPrice.TextAlign = ContentAlignment.MiddleCenter; // Căn giữa chữ

            //    // Thêm các control vào panel sản phẩm
            //    productPanel.Controls.Add(pictureBox);
            //    productPanel.Controls.Add(labelName);
            //    productPanel.Controls.Add(labelPrice);


            //    productPanel.Dock = DockStyle.Left; // Căn chỉnh panel sản phẩm theo chiều dọc
            //    // Thêm panel sản phẩm vào FlowLayoutPanel
            //    pnProduct.Controls.Add(productPanel);
            //}
        }
    }
}
