using BusinessLayer;
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

namespace PresentationLayer
{
    public partial class FrmAllTransaction : Form
    {
        public InventoryTransactionBL inventoryTransactionBL;

        public FrmAllTransaction()
        {
            InitializeComponent();
            inventoryTransactionBL = new InventoryTransactionBL();
        }

        public void LoadTransaction()
        {
            try
            {
                dgvTransaction.DataSource = inventoryTransactionBL.GetTransactions();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to load transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAllTransaction_Load(object sender, EventArgs e)
        {
            dgvTransaction.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTransaction.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTransaction.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            LoadTransaction();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            usUpdateTransaction1.Visible = true;
            usUpdateTransaction1.SetTransactionType("IN");
            usUpdateTransaction1.RefreshIngredients();
            usUpdateTransaction1.TransactionCreated += () => LoadTransaction();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            usUpdateTransaction1.Visible = true;
            usUpdateTransaction1.SetTransactionType("OUT");
            usUpdateTransaction1.RefreshIngredients();
            usUpdateTransaction1.TransactionCreated += () => LoadTransaction();
        }
    }
}
