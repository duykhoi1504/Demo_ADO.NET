using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class InventoryTransaction
    {
        public int id {  get; set; }
        public string ingredientID { get; set; }
        public int quantity { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public string note { get; set; }
        public InventoryTransaction(int id, string ingredientID, int quantity, string type, DateTime date, string note)
        {
            this.id = id;
            this.ingredientID = ingredientID;
            this.quantity = quantity;
            this.type = type;
            this.date = date;
            this.note = note;
        }
    }
}
