using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class USAddProduct : UserControl
    {
        public ProductBL productBL;

        public USAddProduct()
        {
            InitializeComponent();
            productBL = new ProductBL();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictProduct.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string id, name, image;
            float price, discount;
            int categoryID;

            id = txtPID.Text;
            name = txtPName.Text;
            price = float.Parse(txtPPrice.Text);
            discount = float.Parse(txtPDiscount.Text);
            categoryID = int.Parse(cboCategory.SelectedValue.ToString());

            byte[] imageData = null;
            if (pictProduct.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictProduct.Image.Save(ms, pictProduct.Image.RawFormat);
                    imageData = ms.ToArray();
                }
            }

            Product p = new Product(id, name, price, discount, categoryID, imageData);
            try
            {
                productBL.AddProduct(p);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtPName.Clear();
            txtPPrice.Clear();
            txtPDiscount.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
