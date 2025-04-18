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
    public partial class Suppliers : Form, IObserver
    {

        private SupplierBL supplierBL;
        public Suppliers()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
            Observer.Register(this);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
 
            //AddSupplier.UpdateDataGridView += ResetDataGridView;
            try
            {
                dataGridView1.DataSource = supplierBL.GetSuppliers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ResetDataGridView()
        {
            // Làm mới DataGridView
            dataGridView1.DataSource = supplierBL.GetSuppliers();
        }

        public void OnNotify(string key)
        {
            if (key == "UpdateDataGridView1")
            {
                // Làm mới DataGridView
                ResetDataGridView();
            }
        }
        private void AddSupllier_Click(object sender, EventArgs e)
        {
            addSupplier1.Visible = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID của nhà cung cấp từ hàng được chọn
                string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        supplierBL.deleteSupplier(id);

                        // Làm mới DataGridView sau khi xóa
                        ResetDataGridView();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }

       
    }
} 
