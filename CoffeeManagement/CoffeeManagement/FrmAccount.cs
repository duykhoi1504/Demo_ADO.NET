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

namespace PresentationLayer
{
    public partial class FrmAccount : Form
    {
        private AccountBL accountBL;

        public FrmAccount()
        {
            InitializeComponent();
            accountBL = new AccountBL();
        }

        private bool InvalidFields()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || 
                string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPassword.Text.Length < 3)
            {
                MessageBox.Show("Password cannot be less than 3 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string username = txtUsername.Text;
            if (accountBL.IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please enter a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPhoneNumber.Text.Length != 10 || !txtPhoneNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LoadAccount()
        {
            try
            {
                dgvAccounts.DataSource = accountBL.GetAccounts();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();

            List<String> names = new List<String>() { "Id", "Username", "Password", "Role", "FullName", "Sex", "DateOfBirth", "Address", "PhoneNumber", "DateOfRegistration" };

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
            dgvAccounts.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAccounts.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            return dgv;
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            CustomDataGridView(dgvAccounts);
            LoadAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!InvalidFields()) { return; }

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullname = txtFullName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text;
            string role = cbRole.Text;
            string sex = cbSex.Text;
            DateTime dob = dtpDOB.Value;
            DateTime dor = DateTime.Now;

            Account a = new Account(0, username, password, role, fullname, sex, dob, address, phoneNumber, dor);

            try
            {
                accountBL.AddAccount(a);
                MessageBox.Show("Account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtFullName.Clear();
            txtPhoneNumber.Clear();
            cbRole.SelectedIndex = -1;
            cbSex.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (dgvAccounts.Columns[col] is DataGridViewImageColumn)
            {
                if (row >= 0 && col == dgvAccounts.Columns["Update"].Index)
                {
                    var a = (Account)dgvAccounts.Rows[row].DataBoundItem;
                    if (a != null)
                    {
                        usUpdateAccount1.Visible = true;
                        usUpdateAccount1.LoadAccountForUpdate(a);
                        usUpdateAccount1.AccountUpdated += () => LoadAccount();
                    }
                }
                else if (e.ColumnIndex == dgvAccounts.Columns["Delete"].Index)
                {
                    var idCol = dgvAccounts.Columns["Id"].Index;
                    int id = Convert.ToInt32(dgvAccounts.Rows[row].Cells[idCol].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            accountBL.DeleteAccount(id);
                            MessageBox.Show("Account has been successfully deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAccount();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error deleting account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
