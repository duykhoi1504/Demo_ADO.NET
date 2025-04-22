using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace TransferObject
{
    public class Order
    {
        public string id { get; set; }
        public string createdDate { get; set; }
        public string totalPrice { get; set; }
        public string paymentMethod { get; set; }



        public string accountID { get; set; }
        //if item[?] == order.ID
        public List<Item> Items { get; set; }
        public Order(string id, string createdDate, string totalPrice, string paymentMethod, string accountID,List<Item>items)
        {
            this.id = id;
            this.createdDate = createdDate;
            this.totalPrice = totalPrice;
            this.paymentMethod = paymentMethod;
            this.accountID = accountID;
            foreach(Item item in items)
            {
                if (item.orderID == id)
                {
                    Items.Add(item);
                }
            }
        }

    }
}
