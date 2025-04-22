using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Product
    {
        public string id { get; set; }

        public string name { get; set; }
        public string price { get; set; }
        public string discount { get; set; }
        public string categoryID { get; set; }
        public Product(string id, string name, string price, string discount, string categoryID)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.discount = discount;
            this.categoryID = categoryID;
        }
        //public string supplierId { get; set; }
        //public Product(string name, string supplierId)
        //{
        //    this.name = name;
        //    this.supplierId = supplierId;
        //}
    }
}
