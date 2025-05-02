namespace PresentationLayer
{
    partial class FrmChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_StatByProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            chart_StatByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btn_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)chart_StatByProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_StatByMonth).BeginInit();
            SuspendLayout();
            // 
            // chart_StatByProduct
            // 
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.Name = "ChartArea1";
            chart_StatByProduct.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.Name = "Legend1";
            chart_StatByProduct.Legends.Add(legend1);
            chart_StatByProduct.Location = new Point(1, 42);
            chart_StatByProduct.Name = "chart_StatByProduct";
            chart_StatByProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowOffset = 8;
            series1.YValuesPerPoint = 5;
            chart_StatByProduct.Series.Add(series1);
            chart_StatByProduct.Size = new Size(1085, 259);
            chart_StatByProduct.TabIndex = 0;
            chart_StatByProduct.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Thống kê";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(472, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(234, 27);
            txtSearch.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 12);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 1;
            label4.Text = "tìm kiếm theo năm";
            // 
            // chart_StatByMonth
            // 
            chartArea2.Name = "ChartArea1";
            chart_StatByMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_StatByMonth.Legends.Add(legend2);
            chart_StatByMonth.Location = new Point(12, 307);
            chart_StatByMonth.Name = "chart_StatByMonth";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Month";
            series2.YValuesPerPoint = 5;
            chart_StatByMonth.Series.Add(series2);
            chart_StatByMonth.Size = new Size(1074, 328);
            chart_StatByMonth.TabIndex = 3;
            chart_StatByMonth.Text = "chart1";
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(712, 8);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 4;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // FrmChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 646);
            Controls.Add(btn_Search);
            Controls.Add(chart_StatByMonth);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(chart_StatByProduct);
            Name = "FrmChart";
            Text = "FrmChart";
            Load += FrmChart_Load;
            ((System.ComponentModel.ISupportInitialize)chart_StatByProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_StatByMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_StatByProduct;
        private Label label1;
        private TextBox txtSearch;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_StatByMonth;
        private Button btn_Search;
    }
}