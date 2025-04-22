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
    public partial class USProdItem : UserControl
    {
        public USProdItem()
        {
            InitializeComponent();
        }
        public void SetProdInfo(string name, string price, Image img)
        {
            lbProdName.Text = name;
            lbProdPrice.Text = price;
            if (img != null)
            {
                picProd.Image = img;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //do something
            MessageBox.Show("You clicked on " + lbProdName.Text);
        }
    }
}
