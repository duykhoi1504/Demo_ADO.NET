using BusinessLayer;
using DataLayer;
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
    public partial class FrmCoupons : Form
    {
        private CouponBL couponBL;

        public FrmCoupons()
        {
            InitializeComponent();
            couponBL = new CouponBL();
        }

        private bool InvalidFields()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtDes.Text) || string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtID.Text.Length > 10)
            {
                MessageBox.Show("Coupon ID cannot be more than 10 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string id = txtID.Text;
            if (couponBL.IsCouponIdExists(id))
            {
                MessageBox.Show("Coupon ID already exists. Please enter a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LoadCoupon()
        {
            try
            {
                dgvCoupons.DataSource = couponBL.GetCoupons();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();

            List<String> names = new List<String>() { "Id", "Description", "Value" };

            for (int i = 0; i < names.Count; i++)
            {
                dgv.Columns[i].Name = names[i];
                dgv.Columns[i].DataPropertyName = names[i];
            }

            DataGridViewImageColumn updateColumn = new DataGridViewImageColumn
            {
                Name = "Update",
                Image = Properties.Resources.cat_write,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(updateColumn);

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
            {
                Name = "Delete",
                Image = Properties.Resources.cat_delete,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(deleteColumn);

            //Custom cao, rộng các cột
            dgv.RowTemplate.Height = 50;
            dgv.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            return dgv;
        }

        private void FrmCoupons_Load(object sender, EventArgs e)
        {
            dgvCoupons = CustomDataGridView(dgvCoupons);
            LoadCoupon();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtValue.Clear();
            txtDes.Clear();
        }

        private void dgvCoupons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (dgvCoupons.Columns[col] is DataGridViewImageColumn)
            {
                if (row >= 0 && col == dgvCoupons.Columns["Update"].Index)
                {
                    var c = (Coupon)dgvCoupons.Rows[row].DataBoundItem;
                    if (c != null)
                    {
                        usUpdateCoupon1.Visible = true;
                        usUpdateCoupon1.LoadCouponForUpdate(c);
                        usUpdateCoupon1.CouponUpdated += () => LoadCoupon();
                    }
                }
                else if (e.ColumnIndex == dgvCoupons.Columns["Delete"].Index)
                {
                    var idCol = dgvCoupons.Columns["Id"].Index;
                    var id = dgvCoupons.Rows[row].Cells[idCol].Value.ToString();

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this coupon?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            couponBL.DeleteCoupon(id);
                            MessageBox.Show("Coupon has been successfully deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCoupon();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error deleting coupon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!InvalidFields()) { return; }

            string id = txtID.Text.Trim();
            string description = txtDes.Text.Trim();
            float value;

            if (!float.TryParse(txtValue.Text, out value))
            {
                MessageBox.Show("Value must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Coupon c = new Coupon(id, description, value);
            try
            {
                couponBL.AddCoupon(c);
                MessageBox.Show("Coupon added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCoupon();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
