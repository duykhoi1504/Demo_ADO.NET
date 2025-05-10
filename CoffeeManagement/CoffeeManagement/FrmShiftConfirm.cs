using BusinessLayer;
using CoffeeManagement;
using DataLayer;
using Microsoft.VisualBasic;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace PresentationLayer
{
    public partial class FrmShiftConfirm : Form
    {
        WorkdayBL workdayBL;
        ShiftBL shiftBL;
        AccountBL accountBL;
        Account account;
        DateTime dateTime;
        List<Account> accounts;
        List<Workday> workdays;
        List<Shift> shifts;

        public FrmShiftConfirm()
        {
            InitializeComponent();
            accountBL = new AccountBL();
            workdayBL = new WorkdayBL();
            shiftBL = new ShiftBL();
            account = Form1.Instance.account;
            dateTime = DateTime.Today;

        }
        private void FrmShiftConfirm_Load(object sender, EventArgs e)
        {
            dt_Date.Value = dateTime;
            LoadStaffCombox(cbStaff);

            LoadWorkDayOffStaff();

        }
        private void LoadStaffCombox(ComboBox dcombo)
        {
            dcombo.Items.Clear();

            accounts = accountBL.GetAccounts();

            if (accounts == null || accounts.Count == 0)
            {
                MessageBox.Show("No accounts available.");
                return;
            }
            dcombo.DataSource = accounts;
            dcombo.DisplayMember = "fullName";
            dcombo.ValueMember = "id";
            dcombo.SelectedIndex = 0;

        }
        private void cbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadWorkDayOffStaff();
        }
        private void dt_Date_ValueChanged(object sender, EventArgs e)
        {
            LoadWorkDayOffStaff();

        }
        private void LoadWorkDayOffStaff()
        {

            if (cbStaff.SelectedValue == null)
            {
                //MessageBox.Show("Vui lòng chọn một nhân viên.");
                return;
            }
            Account selectedAccount = (Account)cbStaff.SelectedItem;
            int selectedValue = selectedAccount.id; // Giả sử 'id' là thuộc tính của Account
            workdays = workdayBL.GetAllWorkdays(selectedValue);
            dgv_Shift.DataSource = workdays.Where(a =>
                                               a.date.Month == dt_Date.Value.Month
                                                                    && a.date.Year == dt_Date.Value.Year)
                                                                    .ToList();

        }


        private void dgv_Shift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            if (row >= 0 && col == dgv_Shift.Columns["IsChecked"].Index)
            {
                // Bắt đầu chỉnh sửa ô
                dgv_Shift.BeginEdit(true);

                // Lấy giá trị của ô "Checked"
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgv_Shift.Rows[row].Cells["IsChecked"];

                // Đảo ngược giá trị Boolean
                bool isChecked = (checkBoxCell.Value != null && (bool)checkBoxCell.Value);
                checkBoxCell.ReadOnly = false; // Cho phép chỉnh sửa
                checkBoxCell.Value = !isChecked;
                MessageBox.Show("checked: " + checkBoxCell.Value);


                // Lấy giá trị của ô "id" từ hàng đã chọn
                int idValue = int.Parse(dgv_Shift.Rows[row].Cells["AccountID"].Value.ToString());
                DateTime date = DateTime.Parse(dgv_Shift.Rows[row].Cells["Date"].Value.ToString());

                //MessageBox.Show("ID: " + idValue + "\n " + "date " + date);
                workdayBL.UpdateWorkday(date, !isChecked);
                MessageBox.Show("check workday Successful");
                LoadWorkDayOffStaff();
            }
        }

        private void btn_SaveShift_Click(object sender, EventArgs e)
        {
            //LoadWorkDayOffStaff();
            this.Close();
            
        }

        private void btn_CalSalary_Click(object sender, EventArgs e)
        {
            if (cbStaff.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên.");
                return;
            }
            Account selectedAccount = (Account)cbStaff.SelectedItem;
            int selectedValue = selectedAccount.id;
            lb_salary.Text = workdayBL.CalculateSalary(selectedValue, dt_Date.Value.Month, dt_Date.Value.Year).ToString("#,0" + " VNĐ");
        }

   
    }

}
