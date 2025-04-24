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
        public int quantity { get; set; }
        public CartSlot(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
