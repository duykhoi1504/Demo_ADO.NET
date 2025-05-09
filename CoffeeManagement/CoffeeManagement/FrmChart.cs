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

        //ItemBL itemBL;
        //OrderBL orderBL;
        StatsBL statsBL;
        List<Stats> products;
        List<Stats> monthsTotal;
        string year;
        public FrmChart()
        {

            InitializeComponent();
            //itemBL = new ItemBL();
            //orderBL = new OrderBL();
            statsBL = new StatsBL();
            products = new List<Stats>();
            monthsTotal = new List<Stats>();
            year = DateTime.Now.Year.ToString();
            dt_date.Value = DateTime.Now;
        }

        private void FrmChart_Load(object sender, EventArgs e)
        {
            StatsByProduct();
            StatsByMonth();
        }

        private void StatsByProduct()
        {
            // Lấy dữ liệu từ danh sách
            products.Clear();
            products = statsBL.GetStatsByProduct(year);


            // Set title.
            this.chart_StatByProduct.Titles.Clear(); // Clear previous titles
            this.chart_StatByProduct.Titles.Add("Thống kê theo sản phẩm");
            this.chart_StatByProduct.Series.Clear();

            ChartArea chartArea = new ChartArea();
            this.chart_StatByProduct.ChartAreas.Clear();
            this.chart_StatByProduct.ChartAreas.Add(chartArea);
            //this.chart_StatByProduct.ChartAreas[0].AxisX.Interval = 0; // Đặt khoảng cách phù hợp


            // Add series.
            for (int i = 0; i < products.Count; i++)
            {

                // Add series.
                Series series = this.chart_StatByProduct.Series.Add(products[i].name + ":" + products[i].value.ToString("#,0"));
                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY(products[i].name, products[i].value);

            
                // Optional: Show values on bars
                series.IsValueShownAsLabel = false;

            }

            chart_StatByProduct.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            this.chart_StatByProduct.ChartAreas[0].AxisX.Title = "sản phảm";
            this.chart_StatByProduct.ChartAreas[0].AxisY.Title = "doanh thu";
        }
        private void StatsByMonth()
        {
            monthsTotal.Clear();
            monthsTotal = statsBL.GetStatsByMonth(year);


            //string[] seriesName = monthsTotal.Select(p => p.name).ToArray();


            //float[] pointsValue = monthsTotal.Select(p => p.value).ToArray();

            // Set title.
            this.chart_StatByMonth.Titles.Clear(); // Clear previous titles
            this.chart_StatByMonth.Titles.Add("Thống kê theo tháng");
            this.chart_StatByMonth.Series.Clear();


            ChartArea chartArea = new ChartArea();
            this.chart_StatByMonth.ChartAreas.Clear();
            this.chart_StatByMonth.ChartAreas.Add(chartArea);


            // Add series.
            for (int i = 0; i < monthsTotal.Count; i++)
            {
                // Add series.
                Series series = this.chart_StatByMonth.Series.Add(monthsTotal[i].name);
                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY(float.Parse(monthsTotal[i].name), monthsTotal[i].value);
                // Optional: Show values on bars
                series.IsValueShownAsLabel = true;
            }
            this.chart_StatByMonth.ChartAreas[0].AxisX.Title = "Tháng";
            this.chart_StatByMonth.ChartAreas[0].AxisY.Title = "Doanh thu";
        }


 
        private void dt_date_ValueChanged(object sender, EventArgs e)
        {
            year = dt_date.Value.Year.ToString();
            StatsByProduct();
            StatsByMonth();
        }
    }
}
