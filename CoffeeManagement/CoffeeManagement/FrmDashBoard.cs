using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmDashBoard : Form
    {
        AccountBL accountBL;
        StatsBL statsBL;
        public FrmDashBoard()
        {
            InitializeComponent();
            accountBL = new AccountBL();
            statsBL = new StatsBL();
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            LoadDataReview();
         
        }
        private void LoadDataReview()
        {
            int staffCount = 0;
            float todayBecome, YearBecome, MonthBecome, totalBecome;
            //List<Stats> revenues = new List<Stats>();
            List<Stats> revenues2 = new List<Stats>();

            List<Account> staff = new List<Account>();
            revenues2 = statsBL.GetFullDateAndTotalRevenue();
            //revenues = statsBL.GetStatsByMonth(DateTime.Now.Year.ToString());
            YearBecome = revenues2.Where(r => r.date.Year == DateTime.Today.Year).Sum(r => r.value);
            MonthBecome = revenues2.Where(r => r.date.Month == DateTime.Today.Month
                                                                      && r.date.Year == DateTime.Today.Year).Sum(r => r.value);
            todayBecome = revenues2.Where(r => r.date.Date == DateTime.Today.Date).Sum(r => r.value);
            totalBecome = revenues2.Sum(r => r.value);
            staff = accountBL.GetAccounts();
            staffCount = staff.Where(s => s.role == CONSTANT.UserRole.STAFF.ToString()).Count();
            lb_StaffCount.Text = staffCount.ToString();
            lb_YearBecome.Text = YearBecome.ToString("#,0") + " VND";
            lb_MonthBecome.Text = MonthBecome.ToString("#,0") + " VND";
            lb_TodayBecome.Text = todayBecome.ToString("#,0") + " VND";
            lb_totalBecome.Text = totalBecome.ToString("#,0") + " VND";
        }
    }
}
