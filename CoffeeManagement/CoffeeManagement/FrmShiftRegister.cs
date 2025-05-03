using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmShiftRegister : Form
    {
        public FrmShiftRegister()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShiftRegister_Load(object sender, EventArgs e)
        {
            CustomDataGridView(dgv_Shift);
        }
        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();

            //List<String> names = new List<String>() { "Id", "Username", "Password", "Role", "FullName", "Sex", "DateOfBirth", "Address", "PhoneNumber", "DateOfRegistration" };

            //for (int i = 0; i < names.Count; i++)
            //{
            //    dgv.Columns[i].Name = names[i];
            //    dgv.Columns[i].DataPropertyName = names[i];
            //}

            DataGridViewComboBoxColumn dcombo= new DataGridViewComboBoxColumn();
            dcombo.HeaderText = "Shift";
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            dcombo.HeaderText = "check";



            dgv_Shift.Columns.Add(dcombo);
            dgv_Shift.Columns.Add(check);




            return dgv;
        }
    }
}
