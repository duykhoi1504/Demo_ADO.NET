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
    public partial class AddProduct : UserControl
    {
        public ProductBL productBL;

        public AddProduct()
        {
            InitializeComponent();
            productBL = new ProductBL();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            string id, name, image;
            float price, discount;

            id = txtPID.Text;
            name = txtPName.Text;
            price = float.Parse(txtPPrice.Text);
            discount = float.Parse(txtPDiscount.Text);
            image = pictProduct.Image;

            Product p = new Product(id, name, price, discount, image);
            try
            {
                ProductBL.AddProduct(p);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
