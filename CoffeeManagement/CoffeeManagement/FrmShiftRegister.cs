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
using static CONSTANT;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PresentationLayer
{
    public partial class FrmShiftRegister : Form
    {
        Account account;
        AccountBL accountBL;
        WorkdayBL workdayBL;
        //ShiftBL shiftBL;
        List<Account> Accounts;
        List<Shift> Shifts;
        List<DateTime> dates;

        DateTime date;
        public FrmShiftRegister()
        {
            InitializeComponent();
            accountBL = new AccountBL();
            Accounts = new List<Account>();
            account = new Account();
            Shifts = new List<Shift>();
            workdayBL = new WorkdayBL();
            dates = new List<DateTime>();
            //shiftBL = new ShiftBL();
            Accounts = accountBL.GetAccounts();
        }

        private void FrmShiftRegister_Load(object sender, EventArgs e)
        {
            dt_DateStart.Value = DateTime.Now;
            //Shifts = shiftBL.GetShifts();   
            LoadStaffCombox(cb_Staff);


        }

        private void LoadStaffCombox(ComboBox dcombo)
        {
            dcombo.Items.Clear();


            foreach (var a in Accounts)
            {
                dcombo.Items.Add(a.fullName);
            }
            dcombo.SelectedIndex = 0;
        }

        private void dt_DateStart_ValueChanged(object sender, EventArgs e)
        {

            DateTime selectedDate = dt_DateStart.Value;
            string dayOfWeek = selectedDate.DayOfWeek.ToString(); // Lấy thứ
            string formattedDate = selectedDate.ToString("dd-MM-yyyy"); // Định dạng ngày
            lblResult.Text = $"Bạn đã chọn: {dayOfWeek}, {formattedDate}";
            date = selectedDate;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RemoveItem(USShiftItem us)
        {
            // Nếu số lượng bằng 0, xóa sản phẩm khỏi giỏ hàng
            pn_ShiftItems.Controls.Remove(us);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (date == null || account == null)
            {
                MessageBox.Show("Vui lòng chọn ngày hoặc nhân viên");
                return;
            }
            USShiftItem usShiftItem = new USShiftItem(date);
            usShiftItem.Dock = DockStyle.Top;
            //usShiftItem.BringToFront();
            pn_ShiftItems.Controls.Add(usShiftItem);
            usShiftItem.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_Staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            account = Accounts.FirstOrDefault(a => a.fullName == cb_Staff.SelectedItem.ToString());
        }

        private void btn_SaveShift_Click(object sender, EventArgs e)
        {
            Shifts.Clear();
            dates.Clear();

            foreach (USShiftItem a in pn_ShiftItems.Controls)
            {
                // Kiểm tra nếu shift không phải là null trước khi thêm vào danh sách
                if (a.shift != null && a.dateTime != null)
                {
                    Shifts.Add(a.shift);
                    dates.Add(a.dateTime);
                }
            }
            DialogResult checkout = MessageBox.Show("Bạn có chắc chắn thêm ca?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (checkout != DialogResult.Yes) return;

            // Kiểm tra xem panel có rỗng hay không
            if ((pn_ShiftItems == null))
            {
                MessageBox.Show("Vui lòng thêm ca");
                return; // Kết thúc hàm nếu rỗng
            }
            try
            {
                for (int i = 0; i < pn_ShiftItems.Controls.Count; i++)
                {
                    Workday wd = new Workday(account.id, Shifts[i].id, dates[i]);
                    workdayBL.AddWorkday(wd);

                }
                MessageBox.Show("thêm ca làm thành công!");
                pn_ShiftItems.Controls.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi them ca: " + ex.Message);
            }
            //// Tạo chuỗi để hiển thị
            //string m = "";
            //foreach (var a in Shifts)
            //{
            //    m += account.id + "-" + a.name + "-" + a.time + "\n";
            //}

            //// Hiển thị thông báo
            //MessageBox.Show(m);
        }
    }
}
