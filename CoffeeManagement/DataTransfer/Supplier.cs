using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Supplier
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Supplier(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}
