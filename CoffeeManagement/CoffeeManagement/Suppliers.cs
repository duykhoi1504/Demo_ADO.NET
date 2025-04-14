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
using System.Collections.Generic;
using TransferObject;
namespace PresentationLayer
{
    public partial class Suppliers : Form
    {
        
        private SupplierBL supplierBL;
        public Suppliers()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            //addSupplier1.SupplierAdded += AddSupplierControl_SupplierAdded;
            AddSupplier.UpdateDataGridView += AddSupplierControl_SupplierAdded;
            try
            {
                dataGridView1.DataSource = supplierBL.GetSuppliers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

     

        //private void AddSupplierControl_SupplierAdded(object sender, EventArgs e)
        //{
        //    // Làm mới DataGridView
        //    dataGridView1.DataSource = supplierBL.GetSuppliers();
        //}
        private void AddSupplierControl_SupplierAdded()
        {
            // Làm mới DataGridView
            dataGridView1.DataSource = supplierBL.GetSuppliers();
        }
        private void AddSupllier_Click(object sender, EventArgs e)
        {
            addSupplier1.Visible = true;



        }
    }
} 
