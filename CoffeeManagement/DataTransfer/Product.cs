using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Product
    {
        public string name { get; set; }
        public string supplierId { get; set; }
        public Product(string name, string supplierId)
        {
            this.name = name;
            this.supplierId = supplierId;
        }
    }
}
