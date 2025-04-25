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
        public float price { get; set; }
        public float discount { get; set; }
        public int categoryID { get; set; }
        public byte[] image { get; set; }
        public Product(string id, string name, float price, float discount, int categoryID, byte[] image)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.discount = discount;
            this.categoryID = categoryID;
            this.image = image;
        }
    }
}
