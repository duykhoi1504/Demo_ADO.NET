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
            if (prod.image != null)
            {
                using (MemoryStream ms = new MemoryStream(prod.image))
                {
                    img_prod.Image = Image.FromStream(ms);
                }
            }
            else
            {
                img_prod.Image = null; // Clear image if null
            }

        }
        public void ProductInit(Product prod)
        {
            if (prod != null)
                product = prod;
        }




        private void pn_Product_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Item clicked: " + lbProdName.Text);

            FrmMenu frmMenu = (FrmMenu)this.ParentForm;
            //Item item = new Item(lbProdName.Text, lbProdPrice.Text, "1", "1", "1");
            //frmMenu.AddItem(item);
            if (frmMenu != null)
            {
                frmMenu.AddItem(product);
                Observer.Notify(CONSTANT.UpdateProdCart);
            }
        }

        private void pn_Product_MouseHover(object sender, EventArgs e)
        {
            pn_Product.BackColor = Color.LightBlue; // Ví dụ thay đổi màu
        }

        private void pn_Product_MouseEnter(object sender, EventArgs e)
        {
            pn_Product.BackColor = Color.Yellow; // Trả về màu ban đầu
        }

        private void pn_Product_MouseLeave(object sender, EventArgs e)
        {
            pn_Product.BackColor = Color.Transparent; // Trả về màu ban đầu

        }
    }
}
