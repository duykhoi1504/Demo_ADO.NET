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
        //ShiftBL shiftBL;
        List<Account> Accounts;
        List<Shift> Shifts;
        DateTime date;
        public FrmShiftRegister()
        {
            InitializeComponent();
            accountBL = new AccountBL();
            Accounts = new List<Account>();
            account = new Account();
            Shifts= new List<Shift>();
            //shiftBL = new ShiftBL();
        }

        private void FrmShiftRegister_Load(object sender, EventArgs e)
        {
            dt_DateStart.Value = DateTime.Now;
            Accounts = accountBL.GetAccounts();
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
            USShiftItem usShiftItem = new USShiftItem(date, account);
            usShiftItem.Dock = DockStyle.Top;
            usShiftItem.BringToFront();
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
            // Khởi tạo danh sách nếu chưa được khởi tạo
            if (Shifts == null)
            {
                Shifts = new List<Shift>();
            }

            foreach (USShiftItem a in pn_ShiftItems.Controls)
            {
                // Kiểm tra nếu shift không phải là null trước khi thêm vào danh sách
                if (a.shift != null)
                {
                    Shifts.Add(a.shift);
                }
            }

            // Tạo chuỗi để hiển thị
            string m = "";
            foreach (var a in Shifts)
            {
                m +=account.fullName +"-"+ a.name+"-" + a.time + "\n";
            }

            // Hiển thị thông báo
            MessageBox.Show(m);
        }


    }
}
