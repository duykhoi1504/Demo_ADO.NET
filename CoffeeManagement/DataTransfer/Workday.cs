using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Workday
    { 
        public int accountID { get; set; }
        public int shiftID { get; set; }    
        public DateTime date { get; set; }
        public Workday() { }
        public Workday(int accountID, int shiftID, DateTime date)
        {
            this.accountID = accountID;
            this.shiftID = shiftID;
            this.date = date;
        }
    }
}
