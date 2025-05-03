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
        public event Action TransactionCreated;
        public USUpdateTransaction()
        {
            InitializeComponent();
            inventoryTransactionBL = new InventoryTransactionBL();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ingredientID = cbIngredient.Text;
            string type = txtType.Text;
            string note = txtNote.Text;
            DateTime date = dtpDate.Value;
            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InventoryTransaction t = new InventoryTransaction(0, ingredientID, quantity, note, date, note);

            try
            {
                inventoryTransactionBL.AddTransaction(t);
                MessageBox.Show("Transaction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TransactionCreated?.Invoke();
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
            txtType.Clear();
            txtNote.Clear();
            dtpDate.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void USUpdateTransaction_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
