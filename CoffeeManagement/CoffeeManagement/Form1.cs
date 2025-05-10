using BusinessLayer;
using DataLayer;
using PresentationLayer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TransferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace CoffeeManagement
{
    public partial class Form1 : Form
    {
        AccountBL accountBL;
        StatsBL statsBL;
        private static Form1 instance;
        public static Form1 Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }


        public Account account = new Account();
        private SqlConnection cn;
        DataProvider dataProvider = new DataProvider();

        public Form1()
        {
            InitializeComponent();
            instance = this;
            accountBL = new AccountBL();
            statsBL = new StatsBL();
            //cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            this.Hide();
            this.Enabled = false;
            FrmLogin login = new FrmLogin();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                account = login.account;
                //account=accountBL.GetAccounts().FirstOrDefault(i=>i.);
                FrmDashBoard dashBoard = new FrmDashBoard();
                AddForm(dashBoard);
                txt_name.Text = account.Username;
                this.Enabled = true;

            }
            else
            {
                Application.Exit();
            }
        }
        private bool OnlyAdminCanEntry(Account account)
        {

            if (account == null || string.IsNullOrEmpty(account.role))
            {
                MessageBox.Show("Role is not set. Please contact support.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (account.role.ToLower() == CONSTANT.UserRole.STAFF.ToString().ToLower())
            {
                MessageBox.Show("Only For Admin!!!!!!", "From Admin");
                return false;
            }
            return true; // Return true if the user is allowed to enter
        }
        public void AddForm(Form form)
        {
            form.TopLevel = false;
            plMain.Controls.Clear();
            plMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        private void Supplier_Click(object sender, EventArgs e)
        {
            AddForm(new Suppliers());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            AddForm(new FrmMenu());

        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (!OnlyAdminCanEntry(account))
            {
                return;
            }
            AddForm(new FrmReceipt());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            if (!OnlyAdminCanEntry(account))
            {
                return;
            }
            AddForm(new FrmChart());
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            AddForm(new FrmIngredient());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!OnlyAdminCanEntry(account))
            {
                return;
            }
            AddForm(new FrmProducts());
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            if (!OnlyAdminCanEntry(account))
            {
                return;
            }
            AddForm(new FrmAccount());

        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            if (!OnlyAdminCanEntry(account))
            {
                return;
            }
            AddForm(new FrmCoupons());

        }


        private void txt_name_Click(object sender, EventArgs e)
        {
            FrmDashBoard dashBoard = new FrmDashBoard();
            AddForm(dashBoard);
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            LogIn();

        }
        private void plMain_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}