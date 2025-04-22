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
            MessageBox.Show("Item clicked: " + lbProdName.Text);
            FrmMenu frmMenu = (FrmMenu)this.ParentForm;
            Item item = new Item(lbProdName.Text, lbProdPrice.Text, "1", "1", "1");
            frmMenu.AddItem(item);
            Observer.Notify("UpdateProdItems");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
