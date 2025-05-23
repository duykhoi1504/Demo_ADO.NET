﻿using BusinessLayer;
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
    public partial class USAddSupplier : UserControl
    {
        public event EventHandler SupplierAdded;
        //public static event Action UpdateDataGridView;
        public SupplierBL supplierBL;
      
        public USAddSupplier()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
            //this.BringToFront(); // Fixed: Removed incorrect assignment to Dock property  
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

            this.Visible = false;

        }
        public void loadSuplierByID(string id,string name, string address) { 
            txtId.Text = id;
            txtName.Text = name;
            txtAdress.Text = address;
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
                Observer.Notify(CONSTANT.UpdateDataGridView1);
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
