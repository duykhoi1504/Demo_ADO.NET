using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Item
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public string productID { get; set; }

        public int quantity { get; set; }

        //public Product product { get; set; }
        public float price { get; set; }
        public string productName { get; set; }
        public Item() { }
        public Item(int id, int orderID, string productID, int quantity, float price)
        {
            this.id = id;
            this.orderID = orderID;
            this.productID = productID;
            this.quantity = quantity;
            this.price = price;
        }

    }
}
