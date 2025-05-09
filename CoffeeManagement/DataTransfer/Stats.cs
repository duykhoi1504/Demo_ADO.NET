using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Stats
    {
        //public string id;
        public string name;
        public float value;
        public DateTime date;
        public Stats() { }
        public Stats( string name, float value)
        {
            //this.id = id;
            this.name = name;
            this.value = value;
        }
 
    }
}
