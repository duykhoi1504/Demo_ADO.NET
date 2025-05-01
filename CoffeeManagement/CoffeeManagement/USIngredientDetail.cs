using BusinessLayer;
using DataLayer;
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
using TransferObject;

namespace PresentationLayer
{
    public partial class USIngredientDetail : UserControl
    {
        public IngredientBL ingredientBL;
        public SupplierBL supplierBL;
        private Ingredient currentIngredient;

        public event Action UpdateIngredient;

        public USIngredientDetail()
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

            if (cbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier before adding the ingredient.", "Missing Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadSupplier()
        {
            try
            {
                List<Supplier> supps = supplierBL.GetSuppliers();

                cbSupplier.DataSource = supps;
                cbSupplier.ValueMember = "id";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to load suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void LoadIngredientForUpdate(Ingredient i)
        {
            currentIngredient = i;

            txtID.Text = i.id;
            txtName.Text = i.name;
            txtUnit.Text = i.unit;
            txtQuantity.Text = i.quantity.ToString();
            cbStatus.Text = i.status;
            cbSupplier.SelectedValue = i.supplierID;
            dtpEXP.Value = i.expirationDate;

            txtID.Enabled = false;

            this.Visible = true;
        }

        private void USIngredientDetail_Load(object sender, EventArgs e)
        {
            LoadSupplier();
            this.Visible = false;
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
                ingredientBL.UpdateIngredient(i);
                MessageBox.Show("Ingredient updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateIngredient?.Invoke();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error updating ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadIngredientForUpdate(currentIngredient);
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }
    }
}
