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
        Product product;
        public USProdItem()
        {
            InitializeComponent();

        }
        private void USProdItem_Load(object sender, EventArgs e)
        {
            SetProdLabel(product);
        }
        public void SetProdLabel(Product prod)
        {
            if (prod == null)
                return;
            lbProdName.Text = prod.name;
            lbProdPrice.Text = prod.price.ToString();

        }
        public void ProductInit(Product prod)
        {
            if (prod != null)
                product = prod;
        }



        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item clicked: " + lbProdName.Text);
            FrmMenu frmMenu = (FrmMenu)this.ParentForm;
            //Item item = new Item(lbProdName.Text, lbProdPrice.Text, "1", "1", "1");
            //frmMenu.AddItem(item);

            frmMenu.AddItem(product);
            Observer.Notify("UpdateProdCart");

        }

  
    }
}
