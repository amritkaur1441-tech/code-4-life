namespace AVKBookingSystem
{
    partial class ManagerSalesReport
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
            this.chartSalesSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCurrentYear = new System.Windows.Forms.Button();
            this.buttonPrevYear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSalesSeries
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSalesSeries.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSalesSeries.Legends.Add(legend1);
            this.chartSalesSeries.Location = new System.Drawing.Point(77, 21);
            this.chartSalesSeries.Name = "chartSalesSeries";
            this.chartSalesSeries.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SeriesSales";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartSalesSeries.Series.Add(series1);
            this.chartSalesSeries.Size = new System.Drawing.Size(813, 555);
            this.chartSalesSeries.TabIndex = 0;
            this.chartSalesSeries.Text = "chart1";
            // 
            // buttonCurrentYear
            // 
            this.buttonCurrentYear.Location = new System.Drawing.Point(933, 614);
            this.buttonCurrentYear.Name = "buttonCurrentYear";
            this.buttonCurrentYear.Size = new System.Drawing.Size(161, 49);
            this.buttonCurrentYear.TabIndex = 1;
            this.buttonCurrentYear.Text = "Current Year";
            this.buttonCurrentYear.UseVisualStyleBackColor = true;
            // 
            // buttonPrevYear
            // 
            this.buttonPrevYear.Location = new System.Drawing.Point(926, 516);
            this.buttonPrevYear.Name = "buttonPrevYear";
            this.buttonPrevYear.Size = new System.Drawing.Size(168, 49);
            this.buttonPrevYear.TabIndex = 2;
            this.buttonPrevYear.Text = "Previous Year";
            this.buttonPrevYear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Month --------------------------------------->";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(34, 70);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 20);
            this.labelPrice.TabIndex = 4;
            // 
            // ManagerSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 675);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrevYear);
            this.Controls.Add(this.buttonCurrentYear);
            this.Controls.Add(this.chartSalesSeries);
            this.Name = "ManagerSalesReport";
            this.Text = "ManagerSalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesSeries;
        private System.Windows.Forms.Button buttonCurrentYear;
        private System.Windows.Forms.Button buttonPrevYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrice;
    }
}