using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace TransferObject
{
    public class CartSlot
    {

        public Product product { get; set; }
        private  int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                UpdateTotalPrice(); // Gọi để cập nhật totalPrice khi quantity thay đổi
            }
        }

        public float totalPrice { get; set; }
        public CartSlot(Product product, int quantity )
        {
            this.product = product;
            Quantity = quantity;
            //this.totalPrice = totalPrice;



        }
        public void UpdateTotalPrice()
        {
            totalPrice = product.price * Quantity;
        }
    }
}
