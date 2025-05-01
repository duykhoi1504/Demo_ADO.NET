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
        private SupplierBL supplierBL;

        public FrmIngredient()
        {
            InitializeComponent();
            ingredientBL = new IngredientBL();
            supplierBL = new SupplierBL();
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

            if (cbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier before adding the ingredient.", "Missing Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void UpdateStatus()
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity)) return;

            DateTime exp = dtpEXP.Value;

            if (exp < DateTime.Now.Date) { cbStatus.Text = "EXPIRED"; }
            else if (quantity == 0) { cbStatus.Text = "OUT_OF_STOCK"; }
            else if (quantity <= 15) { cbStatus.Text = "LOW_STOCK"; }
            else { cbStatus.Text = "STOCK"; }
        }

        private void LoadSupplier()
        {
            try
            {
                List<Supplier> supps = supplierBL.GetSuppliers();

                cbSupplier.DataSource = supps;
                cbSupplier.ValueMember = "id";
                cbSupplier.SelectedIndex = -1;

                cbFilterbySup.DataSource = supps;
                cbFilterbySup.ValueMember = "id";
                cbFilterbySup.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to load suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClear_Click(object sender, EventArgs e)
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
            if (cbFilterbySup.SelectedValue == null)
            {
                MessageBox.Show("Please select a supplier to filter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string supplierID = cbFilterbySup.SelectedValue.ToString();

            try
            {
                var f = ingredientBL.GetIngredientsBySupplier(supplierID);
                dgvIngredients.DataSource = f;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to filter by supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilterbyStatus_Click(object sender, EventArgs e)
        {
            if (cbFilterbyStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status to filter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string status = cbFilterbyStatus.SelectedItem.ToString();

            try
            {
                var f = ingredientBL.GetIngredientsByStatus(status);
                dgvIngredients.DataSource = f;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to filter by status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LoadSupplier();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.ToLower();

            var allIngs = ingredientBL.GetIngredients();
            var sI = allIngs.Where(i => i.name.ToLower().Contains(s)).ToList();

            dgvIngredients.DataSource = sI;
        }

        private void btnAllProds_Click(object sender, EventArgs e)
        {
            LoadIngredient();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void dtpEXP_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (dgvIngredients.Columns[col] is DataGridViewImageColumn)
            {
                if (row >= 0 && col == dgvIngredients.Columns["Detail"].Index)
                {
                    var i = (Ingredient)dgvIngredients.Rows[row].DataBoundItem;
                    if (i != null)
                    {
                        usIngredientDetail1.Visible = true;
                        usIngredientDetail1.LoadIngredientForUpdate(i);
                        usIngredientDetail1.UpdateIngredient += () => LoadIngredient();
                    }
                }
                else if (e.ColumnIndex == dgvIngredients.Columns["Delete"].Index)
                {
                    var idCol = dgvIngredients.Columns["Id"].Index;
                    var id = dgvIngredients.Rows[row].Cells[idCol].Value.ToString();

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this ingredient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ingredientBL.DeleteIngredient(id);
                            MessageBox.Show("Ingredient has been successfully deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadIngredient();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error deleting ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
