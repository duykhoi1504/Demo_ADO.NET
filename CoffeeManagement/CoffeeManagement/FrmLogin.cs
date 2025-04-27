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
using BusinessLayer;
using DataLayer;
using CoffeeManagement;

namespace PresentationLayer
{
    public partial class FrmLogin : Form
    {
        private LoginBL loginBL;
        public string UserName;
        public Account account;
        public FrmLogin()
        {
            InitializeComponent();
            loginBL = new LoginBL();

        }
        
        private bool UserLogin(Account a)
        {
            try
            {
                return loginBL.Login(a);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("123456:");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text.Trim();
            password = txtPassword.Text;

            Account ac = new Account(username, password);

            if (UserLogin(ac))
            {
                UserName = username;

                account = loginBL.GetAccount(username, password);
               
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult result = MessageBox.Show("The Username or Password is Incorrect!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            string ConString = DataProvider.Instance.GetCntr();

            SqlConnection cnn = new SqlConnection(ConString);
            string sql = "SELECT * FROM Account";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            string accs = "";
            while (reader.Read())
            {
                accs += reader["username"].ToString() + " " + reader["password"].ToString() + "\n";
            }
            MessageBox.Show(accs);

            cnn.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }
    }
}
