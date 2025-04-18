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
using TransferObject;

namespace PresentationLayer
{
    public partial class AddSupplier : UserControl
    {
        public event EventHandler SupplierAdded;
        public static event Action UpdateDataGridView;
        public SupplierBL supplierBL;
        public AddSupplier()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void SaveSupplier_Click(object sender, EventArgs e)
        {
            string id, name, address;
            id = txtId.Text;
            name = txtName.Text;
            address = txtAdress.Text;
            Supplier s = new Supplier(id, name, address);
            try
            {
                supplierBL.AddSupplier(s);
                //SupplierAdded?.Invoke(this, EventArgs.Empty);
                Observer.Notify("UpdateDataGridView1");
                //UpdateDataGridView?.Invoke();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Visible = false;
                
            }
        }
    }
}
