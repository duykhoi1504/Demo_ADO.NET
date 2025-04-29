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
    public partial class USUpdateAccount : UserControl
    {
        public event Action AccountUpdated;

        public AccountBL accountBL;

        public USUpdateAccount()
        {
            InitializeComponent();
            accountBL = new AccountBL();
        }

        private bool InvalidFields()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMobile.Text.Length != 10 || !txtMobile.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void LoadAccountForUpdate(Account a)
        {
            txtID.Text = a.id.ToString();
            txtUsername.Text = a.Username;
            txtPassword.Text = a.Password;
            txtFullName.Text = a.fullName;
            txtAddress.Text = a.address;
            txtMobile.Text = a.phoneNumber;
            dtpDOB.Value = a.dateOfBirth;
            dtpDOR.Value = a.dateOfRegistration;

            txtID.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            dtpDOR.Enabled = false;

            this.Visible = true;
        }

        private void USUpdateAccount_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!InvalidFields()) { return; }

            int id = int.Parse(txtID.Text);
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullname = txtFullName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phoneNumber = txtMobile.Text;
            string role = cbRole.Text;
            string sex = cbSex.Text;
            DateTime dob = dtpDOB.Value;
            DateTime dor = dtpDOR.Value;

            Account a = new Account(id, username, password, role, fullname, sex, dob, address, phoneNumber, dor);
            try
            {
                accountBL.UpdateAccount(a);
                MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountUpdated?.Invoke();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error updating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtFullName.Clear();
            txtMobile.Clear();
            cbRole.SelectedIndex = -1;
            cbSex.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
        }
    }
}
