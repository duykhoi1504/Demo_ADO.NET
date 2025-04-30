using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Ingredient
    {
        public string id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int quantity { get; set; }
        public DateTime expirationDate { get; set; }
        public string status { get; set; }
        public string supplierID { get; set; }
        public Ingredient(string id, string name, string unit, int quantity, DateTime expirationDate, string status, string supplierID)
        {
            this.id = id;
            this.name = name;
            this.unit = unit;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
            this.status = status;
            this.supplierID = supplierID;
        }
    }
}
