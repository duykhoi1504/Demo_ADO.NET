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
    public partial class FrmWorkdayList : Form
    {
        WorkdayBL workdayBL;
        ShiftBL shiftBL;
        public FrmWorkdayList()
        {
            InitializeComponent();
         
            workdayBL = new WorkdayBL();
            shiftBL = new ShiftBL();
        }

        private void FrmWorkdayList_Load(object sender, EventArgs e)
        {
            dgv_Workdays.DataSource= workdayBL.GetAllWorkdays(0);
        }
    }
}
