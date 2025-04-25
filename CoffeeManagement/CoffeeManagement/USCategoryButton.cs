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
    public partial class USCategoryButton : UserControl
    {
        public event EventHandler CategoryClicked;

        public USCategoryButton()
        {
            InitializeComponent();
        }

        public void SetCategoryName(string name)
        {
            btnCategory.Text = name;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
