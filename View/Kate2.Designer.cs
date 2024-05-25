using System.ComponentModel;

namespace LR3
{
    partial class Kate2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.table = new System.Windows.Forms.DataGridView();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCalc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Year, this.Price });
            this.table.Location = new System.Drawing.Point(30, 20);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(280, 420);
            this.table.TabIndex = 0;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена за 1 м^2";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // chartYear
            // 
            chartArea1.Name = "ChartArea1";
            this.chartYear.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYear.Legends.Add(legend1);
            this.chartYear.Location = new System.Drawing.Point(436, 20);
            this.chartYear.Name = "chartYear";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartYear.Series.Add(series1);
            this.chartYear.Size = new System.Drawing.Size(729, 318);
            this.chartYear.TabIndex = 1;
            this.chartYear.Text = "chart1";
            // 
            // chartCalc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCalc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCalc.Legends.Add(legend2);
            this.chartCalc.Location = new System.Drawing.Point(436, 367);
            this.chartCalc.Name = "chartCalc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCalc.Series.Add(series2);
            this.chartCalc.Size = new System.Drawing.Size(729, 326);
            this.chartCalc.TabIndex = 2;
            this.chartCalc.Text = "chart1";
            // 
            // Kate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 855);
            this.Controls.Add(this.chartCalc);
            this.Controls.Add(this.chartYear);
            this.Controls.Add(this.table);
            this.Name = "Kate2";
            this.Text = "Kate2";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chartYear;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalc;

        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;

        private System.Windows.Forms.DataGridView table;

        #endregion
    }
}