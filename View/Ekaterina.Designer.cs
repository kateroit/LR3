using System.ComponentModel;

namespace LR3
{
    partial class Ekaterina
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
            this.January = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.February = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.March = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.April = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.June = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.July = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.August = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.September = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.October = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.November = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.December = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Year, this.January, this.February, this.March, this.April, this.May, this.June, this.July, this.August, this.September, this.October, this.November, this.December });
            this.table.Location = new System.Drawing.Point(11, 13);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(772, 203);
            this.table.TabIndex = 0;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // January
            // 
            this.January.HeaderText = "Январь";
            this.January.MinimumWidth = 6;
            this.January.Name = "January";
            this.January.ReadOnly = true;
            this.January.Width = 125;
            // 
            // February
            // 
            this.February.HeaderText = "Февраль";
            this.February.MinimumWidth = 6;
            this.February.Name = "February";
            this.February.ReadOnly = true;
            this.February.Width = 125;
            // 
            // March
            // 
            this.March.HeaderText = "Март";
            this.March.MinimumWidth = 6;
            this.March.Name = "March";
            this.March.ReadOnly = true;
            this.March.Width = 125;
            // 
            // April
            // 
            this.April.HeaderText = "Апрель";
            this.April.MinimumWidth = 6;
            this.April.Name = "April";
            this.April.ReadOnly = true;
            this.April.Width = 125;
            // 
            // May
            // 
            this.May.HeaderText = "Май";
            this.May.MinimumWidth = 6;
            this.May.Name = "May";
            this.May.ReadOnly = true;
            this.May.Width = 125;
            // 
            // June
            // 
            this.June.HeaderText = "Июнь";
            this.June.MinimumWidth = 6;
            this.June.Name = "June";
            this.June.ReadOnly = true;
            this.June.Width = 125;
            // 
            // July
            // 
            this.July.HeaderText = "Июль";
            this.July.MinimumWidth = 6;
            this.July.Name = "July";
            this.July.ReadOnly = true;
            this.July.Width = 125;
            // 
            // August
            // 
            this.August.HeaderText = "Август";
            this.August.MinimumWidth = 6;
            this.August.Name = "August";
            this.August.ReadOnly = true;
            this.August.Width = 125;
            // 
            // September
            // 
            this.September.HeaderText = "Сентябрь";
            this.September.MinimumWidth = 6;
            this.September.Name = "September";
            this.September.ReadOnly = true;
            this.September.Width = 125;
            // 
            // October
            // 
            this.October.HeaderText = "Октябрь";
            this.October.MinimumWidth = 6;
            this.October.Name = "October";
            this.October.ReadOnly = true;
            this.October.Width = 125;
            // 
            // November
            // 
            this.November.HeaderText = "Ноябрь";
            this.November.MinimumWidth = 6;
            this.November.Name = "November";
            this.November.ReadOnly = true;
            this.November.Width = 125;
            // 
            // December
            // 
            this.December.HeaderText = "Декабрь";
            this.December.MinimumWidth = 6;
            this.December.Name = "December";
            this.December.ReadOnly = true;
            this.December.Width = 125;
            // 
            // chartYear
            // 
            chartArea1.Name = "ChartArea1";
            this.chartYear.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYear.Legends.Add(legend1);
            this.chartYear.Location = new System.Drawing.Point(809, 13);
            this.chartYear.Name = "chartYear";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.LegendText = "2009-2023";
            series1.Name = "Series1";
            this.chartYear.Series.Add(series1);
            this.chartYear.Size = new System.Drawing.Size(734, 331);
            this.chartYear.TabIndex = 1;
            this.chartYear.Text = "chart1";
            // 
            // chartCalc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCalc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCalc.Legends.Add(legend2);
            this.chartCalc.Location = new System.Drawing.Point(179, 381);
            this.chartCalc.Name = "chartCalc";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.LegendText = "2009-2023";
            series2.Name = "Series1";
            this.chartCalc.Series.Add(series2);
            this.chartCalc.Size = new System.Drawing.Size(1135, 395);
            this.chartCalc.TabIndex = 2;
            this.chartCalc.Text = "chart1";
            // 
            // Ekaterina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 828);
            this.Controls.Add(this.chartCalc);
            this.Controls.Add(this.chartYear);
            this.Controls.Add(this.table);
            this.Name = "Ekaterina";
            this.Text = "Ekaterina";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn January;
        private System.Windows.Forms.DataGridViewTextBoxColumn February;
        private System.Windows.Forms.DataGridViewTextBoxColumn March;
        private System.Windows.Forms.DataGridViewTextBoxColumn April;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn June;
        private System.Windows.Forms.DataGridViewTextBoxColumn July;
        private System.Windows.Forms.DataGridViewTextBoxColumn August;
        private System.Windows.Forms.DataGridViewTextBoxColumn September;
        private System.Windows.Forms.DataGridViewTextBoxColumn October;
        private System.Windows.Forms.DataGridViewTextBoxColumn November;
        private System.Windows.Forms.DataGridViewTextBoxColumn December;

        private System.Windows.Forms.DataGridView table;

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalc;
    }
}