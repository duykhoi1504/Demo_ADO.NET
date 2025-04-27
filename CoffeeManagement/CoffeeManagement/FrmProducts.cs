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
using TransferObject;
using BusinessLayer;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class FrmProducts : Form
    {
        private CategoryBL categoryBL;
        private ProductBL productBL;

        public FrmProducts()
        {
            InitializeComponent();
            categoryBL = new CategoryBL();
            productBL = new ProductBL();
        }

        private void LoadCategory()
        {
            try
            {
                List<Category> cats = new List<Category>();
                cats = categoryBL.GetCategories();

                foreach (var category in cats)
                {
                    USCategoryButton btnCat = new USCategoryButton();
                    btnCat.SetCategoryName(category.name);
                    btnCat.Tag = category.id;
                    btnCat.Dock = DockStyle.Left; // Căn chỉnh button theo chiều dọc

                    btnCat.CategoryClicked += (s, e) => LoadProductByCategory((int)btnCat.Tag);

                    pnlLoadCats.Controls.Add(btnCat);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProductByCategory(int categoryID)
        {
            try
            {
                MessageBox.Show($"Category ID: {categoryID}");
                dgvProducts.DataSource = productBL.GetProductsByCategory(categoryID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProduct()
        {
            try
            {
                dgvProducts.DataSource = productBL.GetProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();

            List<String> names = new List<String>() { "Id", "Name", "Price", "Discount", "CategoryID", "Image" };

            for (int i = 0; i < names.Count; i++)
            {
                dgv.Columns[i].Name = names[i];
                dgv.Columns[i].DataPropertyName = names[i];
            }

            DataGridViewImageColumn updateColumn = new DataGridViewImageColumn
            {
                Name = "Update",
                Image = Properties.Resources.cat_write,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(updateColumn);

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
            {
                Name = "Delete",
                Image = Properties.Resources.cat_delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(deleteColumn);

            //Custom cao, rộng các cột
            dgv.RowTemplate.Height = 200;
            dgv.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            return dgv;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            //Load danh mục sản phẩm
            LoadCategory();

            //Load danh sách sản phẩm
            dgvProducts = CustomDataGridView(dgvProducts);
            LoadProduct();

            // Tải danh mục vào USAddProduct
            var cats = categoryBL.GetCategories();
            usAddProduct1.LoadCategories(cats);

            //Cập nhật danh sách sau khi thêm/sửa sản phẩm
            usAddProduct1.AddProduct += (p) => LoadProduct();
            usAddProduct1.UpdateProduct += (p) => LoadProduct();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            usAddProduct1.Visible = true;
        }

        private void btnAllProds_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgvProducts.Columns[col] is DataGridViewImageColumn)
            {
                int row = e.RowIndex;

                if (row >= 0 && col == dgvProducts.Columns["Update"].Index)
                {
                    var p = (Product)dgvProducts.Rows[row].DataBoundItem; // Lấy sản phẩm từ hàng
                    usAddProduct1.LoadProductForUpdate(p);
                }
                else if (e.ColumnIndex == dgvProducts.Columns["Delete"].Index)
                {
                    var idCol = dgvProducts.Columns["Id"].Index;
                    var id = dgvProducts.Rows[row].Cells[idCol].Value.ToString();

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            productBL.DeleteProduct(id);
                            MessageBox.Show("Product has been successfully deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProduct();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.ToLower();

            var allProducts = productBL.GetProducts();
            var sProducts = allProducts.Where(p => p.name.ToLower().Contains(s)).ToList();

            dgvProducts.DataSource = sProducts;
        }
    }
}
