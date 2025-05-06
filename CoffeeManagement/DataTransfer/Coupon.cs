using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Coupon
    {
        public string id { get; set; }
        public string description { get; set; }
        public float value { get; set; }
        public Coupon( string id, string description, float value)
        {
            this.id = id;
            this.description = description;
            this.value = value;
        }
        public override string ToString() // Đảm bảo phương thức này được override
        {
            return id; // Trả về description để hiển thị trong ComboBox
        }
    }
}
