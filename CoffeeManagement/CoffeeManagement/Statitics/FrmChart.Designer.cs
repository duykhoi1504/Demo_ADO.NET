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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_StatByProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label4 = new Label();
            chart_StatByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dt_date = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)chart_StatByProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_StatByMonth).BeginInit();
            SuspendLayout();
            // 
            // chart_StatByProduct
            // 
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 6;
            chartArea3.AxisY.MaximumAutoSize = 100F;
            chartArea3.Name = "ChartArea1";
            chart_StatByProduct.ChartAreas.Add(chartArea3);
            legend3.Alignment = StringAlignment.Center;
            legend3.Name = "Legend1";
            chart_StatByProduct.Legends.Add(legend3);
            chart_StatByProduct.Location = new Point(1, 42);
            chart_StatByProduct.Name = "chart_StatByProduct";
            chart_StatByProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.ShadowOffset = 8;
            series3.YValuesPerPoint = 5;
            chart_StatByProduct.Series.Add(series3);
            chart_StatByProduct.Size = new Size(1186, 259);
            chart_StatByProduct.TabIndex = 0;
            chart_StatByProduct.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -8);
            label1.Name = "label1";
            label1.Size = new Size(193, 48);
            label1.TabIndex = 1;
            label1.Text = "Statistical";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(302, 12);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 1;
            label4.Text = "tìm kiếm theo năm";
            // 
            // chart_StatByMonth
            // 
            chartArea4.Name = "ChartArea1";
            chart_StatByMonth.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart_StatByMonth.Legends.Add(legend4);
            chart_StatByMonth.Location = new Point(1, 307);
            chart_StatByMonth.Name = "chart_StatByMonth";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Month";
            series4.YValuesPerPoint = 5;
            chart_StatByMonth.Series.Add(series4);
            chart_StatByMonth.Size = new Size(1186, 294);
            chart_StatByMonth.TabIndex = 3;
            chart_StatByMonth.Text = "chart1";
            // 
            // dt_date
            // 
            dt_date.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dt_date.CustomFormat = "yyyy";
            dt_date.Format = DateTimePickerFormat.Custom;
            dt_date.Location = new Point(480, 12);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(98, 27);
            dt_date.TabIndex = 5;
            dt_date.ValueChanged += dt_date_ValueChanged;
            // 
            // FrmChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1199, 605);
            Controls.Add(dt_date);
            Controls.Add(chart_StatByMonth);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(chart_StatByProduct);
            MaximumSize = new Size(1217, 652);
            MinimumSize = new Size(1217, 652);
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
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_StatByMonth;
        private DateTimePicker dt_date;
    }
}