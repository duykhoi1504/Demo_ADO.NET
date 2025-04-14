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
//using DataLayer;
using System.Data.SqlClient;
using BusinessLayer;
using DataLayer;
namespace PresentationLayer
{
    public partial class Login : Form
    {
        //private SqlConnection cn;
        private LoginBL loginBL;
        public string User;



        public Login()
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
        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = Username_txt.Text.Trim();
            password = Password_txt.Text;

            Account ac = new Account(username, password);
            if (UserLogin(ac))
            {
                this.DialogResult = DialogResult.OK;

            }
            else
            {

                DialogResult result = MessageBox.Show("Sai ten dang nhap hoac mat khau", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    Username_txt.Clear();
                    Password_txt.Clear();
                    Username_txt.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("123456:");
        }

    

        private void ShowAccount_Click(object sender, EventArgs e)
        {
            string ConString = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(ConString);
            string sql = "SELECT * FROM Users";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            string accs = "";
            while (reader.Read())
            {
                accs += reader["Username"].ToString() + " " + reader["Password"].ToString() + "\n";
            }
            MessageBox.Show(accs);


            cnn.Close();
        }
    }
}
