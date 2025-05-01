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
            chart_StatByProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart_StatByProduct).BeginInit();
            SuspendLayout();
            // 
            // chart_StatByProduct
            // 
            chartArea1.Name = "ChartArea1";
            chart_StatByProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_StatByProduct.Legends.Add(legend1);
            chart_StatByProduct.Location = new Point(1, 55);
            chart_StatByProduct.Name = "chart_StatByProduct";
            chart_StatByProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_StatByProduct.Series.Add(series1);
            chart_StatByProduct.Size = new Size(1074, 441);
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
            // textBox1
            // 
            textBox1.Location = new Point(472, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 2;
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
            // FrmChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 765);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(chart_StatByProduct);
            Name = "FrmChart";
            Text = "FrmChart";
            Load += FrmChart_Load;
            ((System.ComponentModel.ISupportInitialize)chart_StatByProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_StatByProduct;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
    }
}