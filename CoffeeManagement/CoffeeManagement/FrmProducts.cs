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
            dgv.RowTemplate.Height = 100;
            dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        }

        private void ResetDataGridView()
        {
            dgvProducts.DataSource = productBL.GetProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            usAddProduct1.Visible = true;
        }
    }
}
