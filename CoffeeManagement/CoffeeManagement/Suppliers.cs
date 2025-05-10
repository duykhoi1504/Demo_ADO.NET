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
using DataLayer;
namespace PresentationLayer
{
    public partial class Suppliers : Form, IObserver
    {

        private SupplierBL supplierBL;
        List<Supplier> suppliers;
        public Suppliers()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
            Observer.Register(this);

            suppliers = supplierBL.GetSuppliers();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {

            CustomDataGridView(dataGridView1);
            LoadSupplier();

        }
        private void LoadSupplier()
        {
            try
            {
                if (suppliers.Count > 0)
                {
                    suppliers.Clear();
                    suppliers = supplierBL.GetSuppliers();
                    dataGridView1.DataSource = suppliers;
                }
                else
                {
                    MessageBox.Show("No orders found.");
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();


            List<String> names = new List<String>() { "id", "name", "address" };

            // Clear existing columns first
            dgv.Columns.Clear();

            // Add columns dynamically
            foreach (var name in names)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = name,
                    DataPropertyName = name,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                });
            }

            DataGridViewImageColumn updateColumn = new DataGridViewImageColumn
            {
                Name = "update",
                Image = Properties.Resources.cat_write,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(updateColumn);

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
            {
                Name = "delete",
                Image = Properties.Resources.cat_delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom,

            };
            dgv.Columns.Add(deleteColumn);

            //Custom cao, rộng các cột
            dgv.RowTemplate.Height = 50;
            //dgv.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgv.Columns["address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            return dgv;
        }

        private void ResetDataGridView()
        {
            // Làm mới DataGridView
            dataGridView1.DataSource = supplierBL.GetSuppliers();
        }

        public void OnNotify(string key)
        {
            if (key == CONSTANT.UpdateDataGridView1)
            {
                // Làm mới DataGridView
                ResetDataGridView();
            }
        }

        private void AddSupllier_Click(object sender, EventArgs e)
        {
            //us_addSupplier.Visible = true;
            if (txt_id.Text == "" || txt_name.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Supplier s = new Supplier(txt_id.Text, txt_name.Text, txt_address.Text);
                    supplierBL.AddSupplier(s);

                    // Làm mới DataGridView sau khi xóa
                    ResetDataGridView();
                    MessageBox.Show("Thêm thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (row >= 0 && col == dataGridView1.Columns["update"].Index)
            {

                // Lấy giá trị của ô "id" từ hàng đã chọn
                string idValue = dataGridView1.Rows[row].Cells["id"].Value.ToString();
                //MessageBox.Show(idValue);

                FrmAddSupplier frmAddSupplier = new FrmAddSupplier(idValue);
               frmAddSupplier.ShowDialog();

            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                var idCol = dataGridView1.Columns["id"].Index;
                var id = dataGridView1.Rows[row].Cells[idCol].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this coupon?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //couponBL.DeleteCoupon(id);
                        supplierBL.deleteSupplier(id);
                        MessageBox.Show("Coupon has been successfully deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplier();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Error deleting coupon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_id.Text = "";
            txt_name.Text = "";
            txt_id.Focus();
        }
    }
}
