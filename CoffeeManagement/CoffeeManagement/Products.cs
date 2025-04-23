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

namespace PresentationLayer
{
    public partial class Products : Form
    {
        private CategoryBL categoryBL;

        public Products()
        {
            InitializeComponent();
            categoryBL = new CategoryBL();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            List<Category> cats = new List<Category>();
            cats = categoryBL.GetCategories();

            foreach (var category in cats)
            {
                CategoryButton btnCat = new CategoryButton();
                btnCat.SetCategoryName(category.name);
                btnCat.Dock = DockStyle.Left; // Căn chỉnh button theo chiều dọc

                pnlLoadCats.Controls.Add(btnCat);
            }
        }
    }
}
