using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TransferObject;

namespace PresentationLayer
{
    public partial class FrmChart : Form
    {

        ItemBL itemBL;
        StatsBL statsBL;
        OrderBL orderBL;
        List<Stats> products;
        public FrmChart()
        {

            InitializeComponent();
            itemBL = new ItemBL();
            orderBL = new OrderBL();
            statsBL = new StatsBL();
            products =new List<Stats>();
      
        }

        private void FrmChart_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ danh sách
            products = statsBL.GetStatsByProduct();
            string[] seriesArray = products.Select(p => p.name).Distinct().ToArray();
            float[] pointsArray = products.Select(p => p.value).ToArray();
            //string[] seriesArray = { "2", "3" };
            //float[] pointsArray = { 1,3 };
            chart_StatByProduct.ChartAreas[0].RecalculateAxesScale();
            // Set palette.
            chart_StatByProduct.Palette = ChartColorPalette.SeaGreen;

      


            // Set title.
            this.chart_StatByProduct.Titles.Add("Thống kê theo sản phẩm");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chart_StatByProduct.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
            }
        }
    }
}
