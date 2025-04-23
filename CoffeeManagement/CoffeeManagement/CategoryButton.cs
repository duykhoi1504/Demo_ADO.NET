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
    public partial class CategoryButton : UserControl
    {
        public CategoryButton()
        {
            InitializeComponent();
        }

        public void SetCategoryName(string name)
        {
            btnCategory.Text = name;
        }
    }
}
