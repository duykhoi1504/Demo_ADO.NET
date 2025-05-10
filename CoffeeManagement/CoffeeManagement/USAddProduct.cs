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
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class USAddProduct : UserControl
    {
        public event Action<Product> AddProduct;
        public event Action<Product> UpdateProduct;

        private bool isUpdateProduct = false;
        private Product currentProduct = null;

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

        public void LoadProductForUpdate(Product p)
        {
            isUpdateProduct = true;

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
            txtPID.Enabled = false;

            this.Visible = true;
        }

        public void Reset()
        {
            txtPID.Clear();
            txtPName.Clear();
            txtPPrice.Clear();
            txtPDiscount.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            pictProduct.Image = null;
            lbTitle.Text = "Add Product";

            isUpdateProduct = false;
            currentProduct = null;
            txtPID.Enabled = true;
            this.Visible = false;
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
                try
                {
                    byte[] imgBytes = File.ReadAllBytes(ofd.FileName); // Đọc file thành byte array
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        pictProduct.Image = Image.FromStream(ms); // Load từ memory stream
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!InvalidFields())
            {
                return;
            }

            string id = txtPID.Text.Trim();
            string name = txtPName.Text.Trim();
            float price, discount;
            int categoryID;

            if (!float.TryParse(txtPPrice.Text, out price) || !float.TryParse(txtPDiscount.Text, out discount))
            {
                MessageBox.Show("Price and Discount must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            categoryID = (int)cboCategory.SelectedValue;

            byte[] imageData = null;
            if (pictProduct.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        // Dùng Bitmap tạo bản copy sạch từ hình gốc, tránh lỗi locking file
                        using (Bitmap bmp = new Bitmap(pictProduct.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Luôn save dưới dạng PNG hoặc JPEG
                        }
                        imageData = ms.ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to process image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            Product p = new Product(id, name, price, discount, categoryID, imageData);
            try
            {
                if (isUpdateProduct)
                {
                    productBL.UpdateProduct(p);
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateProduct?.Invoke(p);
                }
                else
                {
                    productBL.AddProduct(p);
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddProduct?.Invoke(p);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Reset();
            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            txtPName.Clear();
            txtPPrice.Clear();
            txtPDiscount.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            pictProduct.Image = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtPDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
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
    }
}
