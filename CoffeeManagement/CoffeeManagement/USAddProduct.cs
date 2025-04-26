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
        public event Action<Product> AddProduct;
        public event Action<Product> UpdateProduct;

        private Product currentProduct;
        public ProductBL productBL;

        public USAddProduct()
        {
            InitializeComponent();
            productBL = new ProductBL();
        }

        private bool InvalidFields()
        {
            if (string.IsNullOrWhiteSpace(txtPID.Text) || string.IsNullOrWhiteSpace(txtPName.Text) || 
                string.IsNullOrWhiteSpace(txtPPrice.Text) || string.IsNullOrWhiteSpace(txtPDiscount.Text) || cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string id = txtPID.Text;
            if (currentProduct == null && productBL.IsProductIdExists(id))
            {
                MessageBox.Show("Product ID already exists. Please enter a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void LoadCategories(List<Category> cats)
        {
            cboCategory.DataSource = cats;
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "id";
        }

        public void SetProduct(Product p)
        {
            currentProduct = p;
            txtPID.Text = p.id;
            txtPName.Text = p.name;
            txtPPrice.Text = p.price.ToString();
            txtPDiscount.Text = p.discount.ToString();
            cboCategory.SelectedValue = p.categoryID;

            if (p.image != null)
            {
                using (MemoryStream ms = new MemoryStream(p.image))
                {
                    pictProduct.Image = Image.FromStream(ms);
                }
            }

            lbTitle.Text = "Update Product";
            btnConfirm.Text = "Update";
        }

        public void Reset()
        {
            currentProduct = null;
            txtPID.Clear();
            txtPName.Clear();
            txtPPrice.Clear();
            txtPDiscount.Clear();
            cboCategory.SelectedValue = 1;
            pictProduct.Image = null;
            lbTitle.Text = "Add Product";
            btnConfirm.Text = "Add";
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
            if (!InvalidFields())
            {
                return;
            }

            string id, name, image;
            float price, discount;
            int categoryID;

            id = txtPID.Text;
            name = txtPName.Text;
            price = float.Parse(txtPPrice.Text);
            discount = float.Parse(txtPDiscount.Text);
            categoryID = (int)cboCategory.SelectedValue;

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
                if (currentProduct == null)
                {
                    productBL.AddProduct(p);
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddProduct?.Invoke(p);
                }
                else
                {
                    productBL.UpdateProduct(p);
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateProduct?.Invoke(p);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtPName.Clear();
            txtPPrice.Clear();
            txtPDiscount.Clear();
            cboCategory.SelectedValue = 0;
            pictProduct.Image = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
