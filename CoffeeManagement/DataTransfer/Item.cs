using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Item
    {
        public string id { get; set; }
        public string orderID { get; set; }
        public string productID { get; set; }

        public int quantity { get; set; }

        //public Product product { get; set; }
        public float price { get; set; }
        public Item(string id, string orderID, string productID, int quantity, float price)
        {
            this.id = id;
            this.orderID = orderID;
            this.productID = productID;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
