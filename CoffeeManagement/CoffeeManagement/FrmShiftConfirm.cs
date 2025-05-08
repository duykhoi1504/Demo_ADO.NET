using BusinessLayer;
using CoffeeManagement;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
    public partial class FrmShiftConfirm : Form
    {
        WorkdayBL workdayBL;
        ShiftBL shiftBL;
        Account account;
        public FrmShiftConfirm(Account account, List<Shift> shift, List<DateTime> dates)
        {
            InitializeComponent();
            workdayBL = new WorkdayBL();
            shiftBL = new ShiftBL();
            account = Form1.Instance.account;
            CustomDataGridView(dgv_Shift);


        }
        public FrmShiftConfirm()
        {
            InitializeComponent();
            workdayBL = new WorkdayBL();
            shiftBL = new ShiftBL();
            account = Form1.Instance.account;
            CustomDataGridView(dgv_Shift);

        }
        private void FrmShiftConfirm_Load(object sender, EventArgs e)
        {
            //CustomDataGridView(dgv_Shift);

            LoadWorkDayOffStaff();
        
        }

        private void LoadWorkDayOffStaff()
        {

            // Giả sử bạn đã có các phương thức để lấy danh sách từ bảng Workday và Shift
            List<Workday> workdays = workdayBL.GetAllWorkdays(1); // Phương thức lấy dữ liệu từ Workday
            List<Shift> shifts = shiftBL.GetShifts(); // Phương thức lấy dữ liệu từ Shift
                                                      //linq
            var result = workdays
            .Where(w => w.accountID == account.id) // Lọc theo accountID
            .Join(
                shifts,
                w => w.shiftID, // Trường để JOIN từ Workday
                s => s.id,      // Trường để JOIN từ Shift
                (w, s) => new
                {
                    Date = w.date,          // Ngày
                    ShiftName = s.name,     // Tên ca
                    ShiftTime = s.time,     // Thời gian ca
                    AccountID = w.accountID, // ID tài khoản
                    IsChecked = w.isChecked   // Trạng thái kiểm tra
                }
            )
            .ToList(); // Chuyển đổi kết quả thành danh sách

            //datagridview
            dgv_Shift.DataSource = result;

        

            dgv_Shift.Refresh(); // Cập nhật lại DataGridView
        }
        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            
            dgv.Rows.Clear();

            // Thêm cột checkbox
            DataGridViewCheckBoxColumn checkedColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "IsChecked",
                Name = "IsChecked",
                DataPropertyName = "IsChecked", // Tên thuộc tính trong đối tượng
                Width = 100, // Chiều rộng của cột
                ReadOnly = false, // Cho phép chỉnh sửa
                //DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter } // Căn giữa
            };

            dgv.Columns.Add(checkedColumn);
         
            return dgv;
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
                checkBoxCell.Value = !isChecked;
                //MessageBox.Show("checked: " + checkBoxCell.Value);


                // Lấy giá trị của ô "id" từ hàng đã chọn
                int idValue = int.Parse(dgv_Shift.Rows[row].Cells["AccountID"].Value.ToString());
                DateTime date = DateTime.Parse(dgv_Shift.Rows[row].Cells["Date"].Value.ToString());

                //MessageBox.Show("ID: " + idValue + "\n " + "date "+date);
                workdayBL.UpdateWorkday(date, !isChecked);
                LoadWorkDayOffStaff();


            }
        }
    }

}
