using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class FrmIngredient : Form
    {
        private IngredientBL ingredientBL;

        public FrmIngredient()
        {
            InitializeComponent();
            ingredientBL = new IngredientBL();
        }

        private bool InvalidFields()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtID.Text.Length > 10)
            {
                MessageBox.Show("Password cannot be more than 10 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string id = txtID.Text;
            if (ingredientBL.IsIngredientIDExists(id))
            {
                MessageBox.Show("Ingredient ID already exists. Please enter a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LoadIngredient()
        {
            try
            {
                dgvIngredients.DataSource = ingredientBL.GetIngredients();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();

            List<String> names = new List<String>() { "Id", "Name", "Unit", "Quantity", "ExpirationDate", "Status", "SupplierID" };

            for (int i = 0; i < names.Count; i++)
            {
                dgv.Columns[i].Name = names[i];
                dgv.Columns[i].DataPropertyName = names[i];
            }

            DataGridViewImageColumn updateColumn = new DataGridViewImageColumn
            {
                Name = "Detail",
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
            dgvIngredients.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            return dgv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!InvalidFields()) { return; }

            string id = txtID.Text;
            string name = txtName.Text.Trim();
            string unit = txtUnit.Text.Trim();
            string status = cbStatus.Text;
            string supplierID = cbSupplier.Text;
            DateTime exp = dtpEXP.Value;
            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ingredient i = new Ingredient(id, name, unit, quantity, exp, status, supplierID);

            try
            {
                ingredientBL.AddIngredient(i);
                MessageBox.Show("Ingredient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIngredient();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtUnit.Clear();
            txtQuantity.Clear();
            cbStatus.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            dtpEXP.Value = DateTime.Now;
        }

        private void btnFilterbySupp_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterbyStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {

        }

        private void FrmIngredient_Load(object sender, EventArgs e)
        {
            CustomDataGridView(dgvIngredients);
            LoadIngredient();
        }
    }
}
