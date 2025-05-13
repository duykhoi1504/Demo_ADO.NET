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
    public partial class USUpdateCoupon : UserControl
    {
        public event Action CouponUpdated;

        public CouponBL couponBL;

        public USUpdateCoupon()
        {
            InitializeComponent();
            couponBL = new CouponBL();
        }

        private void USUpdateCoupon_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void LoadCouponForUpdate(Coupon c)
        {
            txtID.Text = c.id;
            txtDes.Text = c.description;
            txtValue.Text = c.value.ToString();

            txtID.Enabled = false;

            this.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtDes.Text) || string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                couponBL.UpdateCoupon(c);
                MessageBox.Show("Coupon updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CouponUpdated?.Invoke();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error updating coupon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtValue.Clear();
            txtDes.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
