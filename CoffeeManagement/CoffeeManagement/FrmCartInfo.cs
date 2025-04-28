using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmCartInfo : Form
    {
        List<CartSlot> cartSlots;
        OrderBL orderBL;
        ItemBL ItemBL;
        float totalPrice = 0;
        


        public FrmCartInfo(List<CartSlot> cartSlots, float totalPrice)
        {
            InitializeComponent();
            orderBL=new OrderBL();
            ItemBL = new ItemBL();
            this.cartSlots = cartSlots;
            this.totalPrice = totalPrice;
            PoadPaymentMethod();
        }
        private void PoadPaymentMethod()
        {
            cbPaymentMethod.Items.Clear();
      
            Array payment= Enum.GetValues(typeof(CONSTANT.paymentMethod));
            foreach(var a in payment)
            {
                cbPaymentMethod.Items.Add(a.ToString());
            }
            cbPaymentMethod.SelectedIndex = 0;
        }

        private void FrmCartInfo_Load(object sender, EventArgs e)
        {

            try
            {
                var displayList = cartSlots.Select(slot => new
                {
                    ProductName = slot.product.name,
                    Quantity = slot.Quantity,
                    TotalPrice = slot.totalPrice
                }).ToList();

                dgvCart.DataSource = displayList;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbTotalPrice.Text = totalPrice.ToString();
            lbLastTotalPrice.Text = totalPrice.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CONSTANT.paymentMethod.Cash.ToString());
            //float Counterfeit = float.Parse(txtCounterfeit.Text);

            //List<Item> items = new List<Item>();
            //Order order = new Order(totalPrice, Counterfeit, cbPaymentMethod.Text, "1", items);
            //foreach( var slot in cartSlots)
            //{
            //    Item item = new Item(null,order.id,slot.product.id, slot.Quantity, slot.totalPrice);
            //    items.Add(item);
            //}
            //orderBL.InsertOrderWithItems(order);
            /////////
            float Counterfeit = float.Parse(txtCounterfeit.Text);

            Order order = new Order(totalPrice, Counterfeit, cbPaymentMethod.Text, 1);
           
            int newOrderId = orderBL.AddOrder(order);
            foreach (var slot in cartSlots)
            {
                Item item = new Item(1, newOrderId, slot.product.id, slot.Quantity, slot.totalPrice);
                ItemBL.AddItem(item);
            }
            //orderBL.UpdateOrder(order);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
