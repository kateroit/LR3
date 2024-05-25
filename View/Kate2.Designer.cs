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
            this.inf2010 = new System.Windows.Forms.RadioButton();
            this.inf2023 = new System.Windows.Forms.RadioButton();
            this.inf2011 = new System.Windows.Forms.RadioButton();
            this.inf2022 = new System.Windows.Forms.RadioButton();
            this.ing2021 = new System.Windows.Forms.RadioButton();
            this.inf2020 = new System.Windows.Forms.RadioButton();
            this.inf2019 = new System.Windows.Forms.RadioButton();
            this.inf2018 = new System.Windows.Forms.RadioButton();
            this.inf2013 = new System.Windows.Forms.RadioButton();
            this.inf2012 = new System.Windows.Forms.RadioButton();
            this.inf2014 = new System.Windows.Forms.RadioButton();
            this.inf2015 = new System.Windows.Forms.RadioButton();
            this.inf2016 = new System.Windows.Forms.RadioButton();
            this.inf2017 = new System.Windows.Forms.RadioButton();
            this.inf2009 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Year, this.Price });
            this.table.Location = new System.Drawing.Point(30, 20);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(244, 420);
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
            this.chartYear.Location = new System.Drawing.Point(588, 20);
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
            this.chartCalc.Location = new System.Drawing.Point(588, 361);
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
            // ChooseNumber
            // 
            this.ChooseNumber.Location = new System.Drawing.Point(67, 458);
            this.ChooseNumber.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            this.ChooseNumber.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.ChooseNumber.Name = "ChooseNumber";
            this.ChooseNumber.Size = new System.Drawing.Size(207, 22);
            this.ChooseNumber.TabIndex = 3;
            this.ChooseNumber.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // CalcBTN
            // 
            this.CalcBTN.Location = new System.Drawing.Point(67, 486);
            this.CalcBTN.Name = "CalcBTN";
            this.CalcBTN.Size = new System.Drawing.Size(207, 24);
            this.CalcBTN.TabIndex = 4;
            this.CalcBTN.Text = "Рассчитать";
            this.CalcBTN.UseVisualStyleBackColor = true;
            this.CalcBTN.Click += new System.EventHandler(this.CalcBTN_Click);
            // 
            // inf2010
            // 
            this.inf2010.Location = new System.Drawing.Point(312, 61);
            this.inf2010.Name = "inf2010";
            this.inf2010.Size = new System.Drawing.Size(104, 24);
            this.inf2010.TabIndex = 33;
            this.inf2010.TabStop = true;
            this.inf2010.Text = "2010";
            this.inf2010.UseVisualStyleBackColor = true;
            this.inf2010.CheckedChanged += new System.EventHandler(this.inf2010_CheckedChanged);
            // 
            // inf2023
            // 
            this.inf2023.Location = new System.Drawing.Point(516, 128);
            this.inf2023.Name = "inf2023";
            this.inf2023.Size = new System.Drawing.Size(104, 24);
            this.inf2023.TabIndex = 34;
            this.inf2023.TabStop = true;
            this.inf2023.Text = "2023";
            this.inf2023.UseVisualStyleBackColor = true;
            this.inf2023.CheckedChanged += new System.EventHandler(this.inf2023_CheckedChanged);
            // 
            // inf2011
            // 
            this.inf2011.Location = new System.Drawing.Point(312, 85);
            this.inf2011.Name = "inf2011";
            this.inf2011.Size = new System.Drawing.Size(104, 24);
            this.inf2011.TabIndex = 32;
            this.inf2011.TabStop = true;
            this.inf2011.Text = "2011";
            this.inf2011.UseVisualStyleBackColor = true;
            this.inf2011.CheckedChanged += new System.EventHandler(this.inf2011_CheckedChanged);
            // 
            // inf2022
            // 
            this.inf2022.Location = new System.Drawing.Point(516, 106);
            this.inf2022.Name = "inf2022";
            this.inf2022.Size = new System.Drawing.Size(104, 24);
            this.inf2022.TabIndex = 21;
            this.inf2022.TabStop = true;
            this.inf2022.Text = "2022";
            this.inf2022.UseVisualStyleBackColor = true;
            this.inf2022.CheckedChanged += new System.EventHandler(this.inf2022_CheckedChanged);
            // 
            // ing2021
            // 
            this.ing2021.Location = new System.Drawing.Point(516, 85);
            this.ing2021.Name = "ing2021";
            this.ing2021.Size = new System.Drawing.Size(104, 24);
            this.ing2021.TabIndex = 22;
            this.ing2021.TabStop = true;
            this.ing2021.Text = "2021";
            this.ing2021.UseVisualStyleBackColor = true;
            this.ing2021.CheckedChanged += new System.EventHandler(this.ing2021_CheckedChanged);
            // 
            // inf2020
            // 
            this.inf2020.Location = new System.Drawing.Point(516, 61);
            this.inf2020.Name = "inf2020";
            this.inf2020.Size = new System.Drawing.Size(104, 24);
            this.inf2020.TabIndex = 23;
            this.inf2020.TabStop = true;
            this.inf2020.Text = "2020";
            this.inf2020.UseVisualStyleBackColor = true;
            this.inf2020.CheckedChanged += new System.EventHandler(this.inf2020_CheckedChanged);
            // 
            // inf2019
            // 
            this.inf2019.Location = new System.Drawing.Point(516, 39);
            this.inf2019.Name = "inf2019";
            this.inf2019.Size = new System.Drawing.Size(104, 24);
            this.inf2019.TabIndex = 24;
            this.inf2019.TabStop = true;
            this.inf2019.Text = "2019";
            this.inf2019.UseVisualStyleBackColor = true;
            this.inf2019.CheckedChanged += new System.EventHandler(this.inf2019_CheckedChanged);
            // 
            // inf2018
            // 
            this.inf2018.Location = new System.Drawing.Point(422, 128);
            this.inf2018.Name = "inf2018";
            this.inf2018.Size = new System.Drawing.Size(104, 24);
            this.inf2018.TabIndex = 25;
            this.inf2018.TabStop = true;
            this.inf2018.Text = "2018";
            this.inf2018.UseVisualStyleBackColor = true;
            this.inf2018.CheckedChanged += new System.EventHandler(this.inf2018_CheckedChanged);
            // 
            // inf2013
            // 
            this.inf2013.Location = new System.Drawing.Point(312, 128);
            this.inf2013.Name = "inf2013";
            this.inf2013.Size = new System.Drawing.Size(104, 24);
            this.inf2013.TabIndex = 30;
            this.inf2013.TabStop = true;
            this.inf2013.Text = "2013";
            this.inf2013.UseVisualStyleBackColor = true;
            this.inf2013.CheckedChanged += new System.EventHandler(this.inf2013_CheckedChanged);
            // 
            // inf2012
            // 
            this.inf2012.Location = new System.Drawing.Point(312, 106);
            this.inf2012.Name = "inf2012";
            this.inf2012.Size = new System.Drawing.Size(104, 24);
            this.inf2012.TabIndex = 31;
            this.inf2012.TabStop = true;
            this.inf2012.Text = "2012";
            this.inf2012.UseVisualStyleBackColor = true;
            this.inf2012.CheckedChanged += new System.EventHandler(this.inf2012_CheckedChanged);
            // 
            // inf2014
            // 
            this.inf2014.Location = new System.Drawing.Point(422, 39);
            this.inf2014.Name = "inf2014";
            this.inf2014.Size = new System.Drawing.Size(104, 24);
            this.inf2014.TabIndex = 29;
            this.inf2014.TabStop = true;
            this.inf2014.Text = "2014";
            this.inf2014.UseVisualStyleBackColor = true;
            this.inf2014.CheckedChanged += new System.EventHandler(this.inf2014_CheckedChanged);
            // 
            // inf2015
            // 
            this.inf2015.Location = new System.Drawing.Point(422, 61);
            this.inf2015.Name = "inf2015";
            this.inf2015.Size = new System.Drawing.Size(104, 24);
            this.inf2015.TabIndex = 28;
            this.inf2015.TabStop = true;
            this.inf2015.Text = "2015";
            this.inf2015.UseVisualStyleBackColor = true;
            this.inf2015.CheckedChanged += new System.EventHandler(this.inf2015_CheckedChanged);
            // 
            // inf2016
            // 
            this.inf2016.Location = new System.Drawing.Point(422, 85);
            this.inf2016.Name = "inf2016";
            this.inf2016.Size = new System.Drawing.Size(104, 24);
            this.inf2016.TabIndex = 27;
            this.inf2016.TabStop = true;
            this.inf2016.Text = "2016";
            this.inf2016.UseVisualStyleBackColor = true;
            this.inf2016.CheckedChanged += new System.EventHandler(this.inf2016_CheckedChanged);
            // 
            // inf2017
            // 
            this.inf2017.Location = new System.Drawing.Point(422, 106);
            this.inf2017.Name = "inf2017";
            this.inf2017.Size = new System.Drawing.Size(104, 24);
            this.inf2017.TabIndex = 26;
            this.inf2017.TabStop = true;
            this.inf2017.Text = "2017";
            this.inf2017.UseVisualStyleBackColor = true;
            this.inf2017.CheckedChanged += new System.EventHandler(this.inf2017_CheckedChanged);
            // 
            // inf2009
            // 
            this.inf2009.Location = new System.Drawing.Point(312, 39);
            this.inf2009.Name = "inf2009";
            this.inf2009.Size = new System.Drawing.Size(104, 24);
            this.inf2009.TabIndex = 20;
            this.inf2009.TabStop = true;
            this.inf2009.Text = "2009";
            this.inf2009.UseVisualStyleBackColor = true;
            this.inf2009.CheckedChanged += new System.EventHandler(this.inf2009_CheckedChanged);
            // 
            // Kate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 855);
            this.Controls.Add(this.inf2010);
            this.Controls.Add(this.inf2023);
            this.Controls.Add(this.inf2011);
            this.Controls.Add(this.inf2022);
            this.Controls.Add(this.ing2021);
            this.Controls.Add(this.inf2020);
            this.Controls.Add(this.inf2019);
            this.Controls.Add(this.inf2018);
            this.Controls.Add(this.inf2013);
            this.Controls.Add(this.inf2012);
            this.Controls.Add(this.inf2014);
            this.Controls.Add(this.inf2015);
            this.Controls.Add(this.inf2016);
            this.Controls.Add(this.inf2017);
            this.Controls.Add(this.inf2009);
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
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton inf2010;
        private System.Windows.Forms.RadioButton inf2023;
        private System.Windows.Forms.RadioButton inf2011;
        private System.Windows.Forms.RadioButton inf2022;
        private System.Windows.Forms.RadioButton ing2021;
        private System.Windows.Forms.RadioButton inf2020;
        private System.Windows.Forms.RadioButton inf2019;
        private System.Windows.Forms.RadioButton inf2018;
        private System.Windows.Forms.RadioButton inf2013;
        private System.Windows.Forms.RadioButton inf2012;
        private System.Windows.Forms.RadioButton inf2014;
        private System.Windows.Forms.RadioButton inf2015;
        private System.Windows.Forms.RadioButton inf2016;
        private System.Windows.Forms.RadioButton inf2017;
        private System.Windows.Forms.RadioButton inf2009;

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