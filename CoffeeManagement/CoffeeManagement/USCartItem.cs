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
    public partial class USCartItem : UserControl
    {
        CartSlot cartSlot;
        public USCartItem()
        {
            InitializeComponent();
        }
        private void USCartItem_Load(object sender, EventArgs e)
        {
            SetCartLabel();
        }

        public void CartSlotInit(CartSlot CaS)
        {
            if (cartSlot != null)
                return;
            cartSlot = CaS;
        }
        public void SetCartLabel()
        {
            lbNameProd.Text = cartSlot.product.name;

            lbPrice.Text = cartSlot.product.price.ToString();

            lbQuantity.Text = cartSlot.Quantity.ToString();
            lbTotalPrice.Text = (cartSlot.product.price * cartSlot.Quantity).ToString();
            Observer.Notify(CONSTANT.UpdateTotalPriceButton);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            cartSlot.Quantity++;
            SetCartLabel();

            //Observer.Notify("UpdateProdItems");

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            cartSlot.Quantity--;
            //lbQuantity.Text = cartSlot.quantity.ToString();
            SetCartLabel();

            if (cartSlot.Quantity <= 0)
            {
                FrmMenu frmMenu = (FrmMenu)this.ParentForm;
                frmMenu.RemoveItem(cartSlot.product);
                //this.Dispose();
            }


            //Observer.Notify("UpdateProdItems");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
