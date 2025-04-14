using DataLayer;
using PresentationLayer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CoffeeManagement
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        DataProvider dataProvider = new DataProvider();
        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbName.Text ="xin chao: "+ login.UserName;
                this.Enabled = true;
               
            }
            else
            {
                Application.Exit();
            }
        }

        private void AddForm(Form form)
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
    }
}
