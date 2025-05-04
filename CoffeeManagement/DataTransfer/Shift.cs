using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Shift
    {
        public int id { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public string wage { get; set; }
        public Shift() { }
        public Shift(int id, string name, string time, string wage)
        {
            this.id = id;
            this.name = name;
            this.time = time;
            this.wage = wage;
        }
    }
}
