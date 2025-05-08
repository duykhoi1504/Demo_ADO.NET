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
using DataLayer;

namespace PresentationLayer
{
    public partial class USUpdateTransaction : UserControl
    {
        public InventoryTransactionBL inventoryTransactionBL;
        public IngredientBL ingredientBL;

        public event Action TransactionCreated;

        //private string lockedIngredientID = null;
        //private bool selectionLocked = false;
        private string fixedIngredientId = null;

        public USUpdateTransaction()
        {
            InitializeComponent();
            inventoryTransactionBL = new InventoryTransactionBL();
            ingredientBL = new IngredientBL();
        }

        public void SetTransactionType(string type)
        {
            txtType.Text = type;
        }

        public void SetFixedIngredient(string ingredientId)
        {
            fixedIngredientId = ingredientId;
            cbIngredient.SelectedValue = ingredientId;
            cbIngredient.Enabled = false; // Khóa không cho thay đổi
        }

        private void LoadIngredients()
        {
            try
            {
                List<Ingredient> i = ingredientBL.GetIngredients();

                cbIngredient.DataSource = i;
                cbIngredient.DisplayMember = "name";
                cbIngredient.ValueMember = "id";
                //cbIngredient.SelectedIndex = -1;

                if (!string.IsNullOrEmpty(fixedIngredientId))
                {
                    cbIngredient.SelectedValue = fixedIngredientId;
                    cbIngredient.Enabled = false;
                }
                else
                {
                    cbIngredient.SelectedIndex = -1;
                    cbIngredient.Enabled = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to load ingredients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshIngredients()
        {
            LoadIngredients();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbIngredient.SelectedValue == null)
            {
                MessageBox.Show("Please select an ingredient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ingredientID = cbIngredient.SelectedValue.ToString();
            string type = txtType.Text.Trim();
            string note = txtNote.Text.Trim();
            DateTime date = dtpDate.Value;
            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //InventoryTransaction t = new InventoryTransaction(0, ingredientID, quantity, type, date, note);

            try
            {
                InventoryTransaction t = new InventoryTransaction(0, ingredientID, quantity, type, date, note);
                int rowsAffected = inventoryTransactionBL.AddTransaction(t);

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Thêm giao dịch thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //inventoryTransactionBL.AddTransaction(t);

                // Cập nhật số lượng nguyên liệu
                var i = ingredientBL.GetIngredient(ingredientID);

                if (i == null)
                {
                    MessageBox.Show("Ingredient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (type == "IN")
                {
                    i.quantity += quantity;
                }
                else if (type == "OUT")
                {
                    if (i.quantity < quantity)
                    {
                        MessageBox.Show("Not enough quantity to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    i.quantity -= quantity;
                }

                rowsAffected = ingredientBL.UpdateIngredient(i);
                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Error updating quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //ingredientBL.UpdateIngredient(i);

                MessageBox.Show("Transaction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TransactionCreated?.Invoke();
                this.Visible = false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbIngredient.SelectedIndex = -1;
            txtQuantity.Clear();
            txtNote.Clear();
            dtpDate.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fixedIngredientId = null; // Reset khi hủy
            cbIngredient.Enabled = true;

            this.Visible = false;
        }

        private void USUpdateTransaction_Load(object sender, EventArgs e)
        {
            LoadIngredients();
            this.Visible = false;
        }
    }
}
