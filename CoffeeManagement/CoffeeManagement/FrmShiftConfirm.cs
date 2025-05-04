using BusinessLayer;
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
    public partial class FrmShiftConfirm : Form
    {
        WorkdayBL workdayBL;
        public FrmShiftConfirm(Account account, List<Shift> shift, List<DateTime> dates)
        {
            InitializeComponent();
            workdayBL = new WorkdayBL();
        }
        public FrmShiftConfirm()
        {
            InitializeComponent();
            workdayBL = new WorkdayBL();
        }
        private void FrmShiftConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
