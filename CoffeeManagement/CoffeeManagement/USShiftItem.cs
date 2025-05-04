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
    public partial class USShiftItem : UserControl
    {
        DateTime dateTime;
        public Shift shift;
        ShiftBL shiftBL;
        List<Shift> Shifts;
        //Account account;
        public USShiftItem(DateTime date,Account account)
        {
            InitializeComponent();
            shiftBL = new ShiftBL();
            dateTime = date;
            //this.account=account;
            Shifts = shiftBL.GetShifts();

        }

        private void USShiftItem_Load(object sender, EventArgs e)
        {
            lb_Day.Text = dateTime.DayOfWeek.ToString();
            lb_DateTime.Text = dateTime.ToString("dd/MM/yyyy");
            LoadShiftCombox(cb_Shift);
     
        }
        private void LoadShiftCombox(ComboBox dcombo)
        {
            dcombo.Items.Clear();
            foreach (var a in Shifts)
            {
                string m = $"{a.name}-{a.time}";
                dcombo.Items.Add(m);
            }
            dcombo.SelectedIndex = 0;
        }

        private void cb_Shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Shift.SelectedItem != null)
            {
                // Extract the name from the selected item
                string selectedItem = cb_Shift.SelectedItem.ToString();
                string selectedName = selectedItem.Split('-')[0].Trim(); // Get the name part

                // Find the shift based on the extracted name
                shift = Shifts.FirstOrDefault(s => s.name.Contains(selectedName, StringComparison.OrdinalIgnoreCase));

                // Check if shift is null before accessing properties
                if (shift != null)
                {
                    // You can now safely access shift.name and shift.time
                    MessageBox.Show($"Selected Shift: {shift.name} - {shift.time}");
                }
                else
                {
                    MessageBox.Show("Shift not found.");
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            FrmShiftRegister FrmSh = (FrmShiftRegister)this.ParentForm;
            FrmSh.RemoveItem(this);

            //MessageBox.Show(account.fullName+"\n"+shift.name + shift.time + "\n ");


        }
    }
}
