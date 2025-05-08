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
        public bool isChecked { get; set; }


        
        public string name { get; set; }
        public string time { get; set; }

        public Workday() {
            this.isChecked = false;
        }
        public Workday(int accountID, int shiftID, DateTime date, bool isChecked=false)
        {
            this.accountID = accountID;
            this.shiftID = shiftID;
            this.date = date;
            this.isChecked = isChecked;
        }
    }
}
