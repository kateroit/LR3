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
            this.ChooseNumber = new System.Windows.Forms.NumericUpDown();
            this.CalcBTN = new System.Windows.Forms.Button();
            this.ChooseRooms = new System.Windows.Forms.NumericUpDown();
            this.CalcRooms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceRooms = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Year, this.Price });
            this.table.Location = new System.Drawing.Point(30, 20);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(244, 386);
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
            this.chartYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chartYear.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYear.Legends.Add(legend1);
            this.chartYear.Location = new System.Drawing.Point(643, 20);
            this.chartYear.Name = "chartYear";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.LegendText = ".";
            series1.Name = "Series1";
            this.chartYear.Series.Add(series1);
            this.chartYear.Size = new System.Drawing.Size(729, 318);
            this.chartYear.TabIndex = 1;
            this.chartYear.Text = "chart1";
            // 
            // chartCalc
            // 
            this.chartCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chartCalc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCalc.Legends.Add(legend2);
            this.chartCalc.Location = new System.Drawing.Point(643, 344);
            this.chartCalc.Name = "chartCalc";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.LegendText = ".";
            series2.Name = "Series1";
            this.chartCalc.Series.Add(series2);
            this.chartCalc.Size = new System.Drawing.Size(729, 326);
            this.chartCalc.TabIndex = 2;
            this.chartCalc.Text = "chart1";
            // 
            // ChooseNumber
            // 
            this.ChooseNumber.Location = new System.Drawing.Point(360, 446);
            this.ChooseNumber.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            this.ChooseNumber.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.ChooseNumber.Name = "ChooseNumber";
            this.ChooseNumber.Size = new System.Drawing.Size(207, 22);
            this.ChooseNumber.TabIndex = 3;
            this.ChooseNumber.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // CalcBTN
            // 
            this.CalcBTN.Location = new System.Drawing.Point(360, 474);
            this.CalcBTN.Name = "CalcBTN";
            this.CalcBTN.Size = new System.Drawing.Size(207, 24);
            this.CalcBTN.TabIndex = 4;
            this.CalcBTN.Text = "Рассчитать";
            this.CalcBTN.UseVisualStyleBackColor = true;
            this.CalcBTN.Click += new System.EventHandler(this.CalcBTN_Click);
            // 
            // ChooseRooms
            // 
            this.ChooseRooms.Location = new System.Drawing.Point(360, 46);
            this.ChooseRooms.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.ChooseRooms.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.ChooseRooms.Name = "ChooseRooms";
            this.ChooseRooms.Size = new System.Drawing.Size(207, 22);
            this.ChooseRooms.TabIndex = 5;
            this.ChooseRooms.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // CalcRooms
            // 
            this.CalcRooms.Location = new System.Drawing.Point(360, 74);
            this.CalcRooms.Name = "CalcRooms";
            this.CalcRooms.Size = new System.Drawing.Size(207, 24);
            this.CalcRooms.TabIndex = 6;
            this.CalcRooms.Text = "Вычислить";
            this.CalcRooms.UseVisualStyleBackColor = true;
            this.CalcRooms.Click += new System.EventHandler(this.CalcRooms_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(359, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите количество лет";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(359, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите количество комнат";
            // 
            // PriceRooms
            // 
            this.PriceRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PriceRooms.Location = new System.Drawing.Point(317, 108);
            this.PriceRooms.Name = "PriceRooms";
            this.PriceRooms.Size = new System.Drawing.Size(286, 298);
            this.PriceRooms.TabIndex = 9;
            this.PriceRooms.Text = "";
            // 
            // Kate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 706);
            this.Controls.Add(this.PriceRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcRooms);
            this.Controls.Add(this.ChooseRooms);
            this.Controls.Add(this.CalcBTN);
            this.Controls.Add(this.ChooseNumber);
            this.Controls.Add(this.chartCalc);
            this.Controls.Add(this.chartYear);
            this.Controls.Add(this.table);
            this.Name = "Kate2";
            this.Text = "Kate2";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseRooms)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown ChooseRooms;
        private System.Windows.Forms.Button CalcRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox PriceRooms;

        private System.Windows.Forms.NumericUpDown ChooseNumber;
        private System.Windows.Forms.Button CalcBTN;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartYear;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCalc;

        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;

        private System.Windows.Forms.DataGridView table;

        #endregion
    }
}