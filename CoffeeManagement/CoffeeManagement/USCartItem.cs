using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class USCartItem : UserControl
    {
        public USCartItem()
        {
            InitializeComponent();
        }
        public void SetCartInfo(string name, string price)
        {
            lbNameProd.Text = name;
            lbPrice.Text = price;
          
        }

    }
}
