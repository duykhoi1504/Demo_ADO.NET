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
    public partial class FrmAddSupplier : Form
    {
        public SupplierBL supplierBL;
     

        public FrmAddSupplier()
        {
            InitializeComponent();
 
            supplierBL = new SupplierBL();
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
                supplierBL.UpdateSupplier(s);
                MessageBox.Show("Sửa nhà cung cấp thành công!");
                //SupplierAdded?.Invoke(this, EventArgs.Empty);
                Observer.Notify(CONSTANT.UpdateDataGridView1);
                //UpdateDataGridView?.Invoke();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddSupplier_Load(object sender, EventArgs e)
        {

        }
        public void loadSuplierByID(string id, string name, string address)
        {
            txtId.Text = id;
            txtName.Text = name;
            txtAdress.Text = address;
        }

    }
}
