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
            this.ChooseNumber = new System.Windows.Forms.NumericUpDown();
            this.CalcBTN = new System.Windows.Forms.Button();
            this.inf2009 = new System.Windows.Forms.RadioButton();
            this.inf2022 = new System.Windows.Forms.RadioButton();
            this.ing2021 = new System.Windows.Forms.RadioButton();
            this.inf2020 = new System.Windows.Forms.RadioButton();
            this.inf2019 = new System.Windows.Forms.RadioButton();
            this.inf2018 = new System.Windows.Forms.RadioButton();
            this.inf2017 = new System.Windows.Forms.RadioButton();
            this.inf2016 = new System.Windows.Forms.RadioButton();
            this.inf2015 = new System.Windows.Forms.RadioButton();
            this.inf2014 = new System.Windows.Forms.RadioButton();
            this.inf2013 = new System.Windows.Forms.RadioButton();
            this.inf2012 = new System.Windows.Forms.RadioButton();
            this.inf2011 = new System.Windows.Forms.RadioButton();
            this.inf2010 = new System.Windows.Forms.RadioButton();
            this.inf2023 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Year, this.January, this.February, this.March, this.April, this.May, this.June, this.July, this.August, this.September, this.October, this.November, this.December });
            this.table.Location = new System.Drawing.Point(11, 13);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(1676, 203);
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
            this.chartYear.Location = new System.Drawing.Point(850, 405);
            this.chartYear.Name = "chartYear";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.LegendText = ".";
            series1.Name = "Series1";
            this.chartYear.Series.Add(series1);
            this.chartYear.Size = new System.Drawing.Size(837, 395);
            this.chartYear.TabIndex = 1;
            this.chartYear.Text = "chart1";
            // 
            // chartCalc
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCalc.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCalc.Legends.Add(legend2);
            this.chartCalc.Location = new System.Drawing.Point(25, 405);
            this.chartCalc.Name = "chartCalc";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.LegendText = ".";
            series2.Name = "Series1";
            this.chartCalc.Series.Add(series2);
            this.chartCalc.Size = new System.Drawing.Size(837, 395);
            this.chartCalc.TabIndex = 2;
            this.chartCalc.Text = "chart1";
            // 
            // ChooseNumber
            // 
            this.ChooseNumber.Location = new System.Drawing.Point(8, 39);
            this.ChooseNumber.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            this.ChooseNumber.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.ChooseNumber.Name = "ChooseNumber";
            this.ChooseNumber.Size = new System.Drawing.Size(199, 22);
            this.ChooseNumber.TabIndex = 3;
            this.ChooseNumber.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // CalcBTN
            // 
            this.CalcBTN.Location = new System.Drawing.Point(9, 121);
            this.CalcBTN.Name = "CalcBTN";
            this.CalcBTN.Size = new System.Drawing.Size(199, 30);
            this.CalcBTN.TabIndex = 4;
            this.CalcBTN.Text = "Рассчитать";
            this.CalcBTN.UseVisualStyleBackColor = true;
            this.CalcBTN.Click += new System.EventHandler(this.CalcBTN_Click);
            // 
            // inf2009
            // 
            this.inf2009.Location = new System.Drawing.Point(214, 21);
            this.inf2009.Name = "inf2009";
            this.inf2009.Size = new System.Drawing.Size(104, 24);
            this.inf2009.TabIndex = 5;
            this.inf2009.TabStop = true;
            this.inf2009.Text = "2009";
            this.inf2009.UseVisualStyleBackColor = true;
            this.inf2009.CheckedChanged += new System.EventHandler(this.inf2009_CheckedChanged);
            // 
            // inf2022
            // 
            this.inf2022.Location = new System.Drawing.Point(418, 88);
            this.inf2022.Name = "inf2022";
            this.inf2022.Size = new System.Drawing.Size(104, 24);
            this.inf2022.TabIndex = 6;
            this.inf2022.TabStop = true;
            this.inf2022.Text = "2022";
            this.inf2022.UseVisualStyleBackColor = true;
            this.inf2022.CheckedChanged += new System.EventHandler(this.inf2022_CheckedChanged);
            // 
            // ing2021
            // 
            this.ing2021.Location = new System.Drawing.Point(418, 67);
            this.ing2021.Name = "ing2021";
            this.ing2021.Size = new System.Drawing.Size(104, 24);
            this.ing2021.TabIndex = 7;
            this.ing2021.TabStop = true;
            this.ing2021.Text = "2021";
            this.ing2021.UseVisualStyleBackColor = true;
            this.ing2021.CheckedChanged += new System.EventHandler(this.ing2021_CheckedChanged);
            // 
            // inf2020
            // 
            this.inf2020.Location = new System.Drawing.Point(418, 43);
            this.inf2020.Name = "inf2020";
            this.inf2020.Size = new System.Drawing.Size(104, 24);
            this.inf2020.TabIndex = 8;
            this.inf2020.TabStop = true;
            this.inf2020.Text = "2020";
            this.inf2020.UseVisualStyleBackColor = true;
            this.inf2020.CheckedChanged += new System.EventHandler(this.inf2020_CheckedChanged);
            // 
            // inf2019
            // 
            this.inf2019.Location = new System.Drawing.Point(418, 21);
            this.inf2019.Name = "inf2019";
            this.inf2019.Size = new System.Drawing.Size(104, 24);
            this.inf2019.TabIndex = 9;
            this.inf2019.TabStop = true;
            this.inf2019.Text = "2019";
            this.inf2019.UseVisualStyleBackColor = true;
            this.inf2019.CheckedChanged += new System.EventHandler(this.inf2019_CheckedChanged);
            // 
            // inf2018
            // 
            this.inf2018.Location = new System.Drawing.Point(324, 110);
            this.inf2018.Name = "inf2018";
            this.inf2018.Size = new System.Drawing.Size(104, 24);
            this.inf2018.TabIndex = 10;
            this.inf2018.TabStop = true;
            this.inf2018.Text = "2018";
            this.inf2018.UseVisualStyleBackColor = true;
            this.inf2018.CheckedChanged += new System.EventHandler(this.inf2018_CheckedChanged);
            // 
            // inf2017
            // 
            this.inf2017.Location = new System.Drawing.Point(324, 88);
            this.inf2017.Name = "inf2017";
            this.inf2017.Size = new System.Drawing.Size(104, 24);
            this.inf2017.TabIndex = 11;
            this.inf2017.TabStop = true;
            this.inf2017.Text = "2017";
            this.inf2017.UseVisualStyleBackColor = true;
            this.inf2017.CheckedChanged += new System.EventHandler(this.inf2017_CheckedChanged);
            // 
            // inf2016
            // 
            this.inf2016.Location = new System.Drawing.Point(324, 67);
            this.inf2016.Name = "inf2016";
            this.inf2016.Size = new System.Drawing.Size(104, 24);
            this.inf2016.TabIndex = 12;
            this.inf2016.TabStop = true;
            this.inf2016.Text = "2016";
            this.inf2016.UseVisualStyleBackColor = true;
            this.inf2016.CheckedChanged += new System.EventHandler(this.inf2016_CheckedChanged);
            // 
            // inf2015
            // 
            this.inf2015.Location = new System.Drawing.Point(324, 43);
            this.inf2015.Name = "inf2015";
            this.inf2015.Size = new System.Drawing.Size(104, 24);
            this.inf2015.TabIndex = 13;
            this.inf2015.TabStop = true;
            this.inf2015.Text = "2015";
            this.inf2015.UseVisualStyleBackColor = true;
            this.inf2015.CheckedChanged += new System.EventHandler(this.inf2015_CheckedChanged);
            // 
            // inf2014
            // 
            this.inf2014.Location = new System.Drawing.Point(324, 21);
            this.inf2014.Name = "inf2014";
            this.inf2014.Size = new System.Drawing.Size(104, 24);
            this.inf2014.TabIndex = 14;
            this.inf2014.TabStop = true;
            this.inf2014.Text = "2014";
            this.inf2014.UseVisualStyleBackColor = true;
            this.inf2014.CheckedChanged += new System.EventHandler(this.inf2014_CheckedChanged);
            // 
            // inf2013
            // 
            this.inf2013.Location = new System.Drawing.Point(214, 110);
            this.inf2013.Name = "inf2013";
            this.inf2013.Size = new System.Drawing.Size(104, 24);
            this.inf2013.TabIndex = 15;
            this.inf2013.TabStop = true;
            this.inf2013.Text = "2013";
            this.inf2013.UseVisualStyleBackColor = true;
            this.inf2013.CheckedChanged += new System.EventHandler(this.inf2013_CheckedChanged);
            // 
            // inf2012
            // 
            this.inf2012.Location = new System.Drawing.Point(214, 88);
            this.inf2012.Name = "inf2012";
            this.inf2012.Size = new System.Drawing.Size(104, 24);
            this.inf2012.TabIndex = 16;
            this.inf2012.TabStop = true;
            this.inf2012.Text = "2012";
            this.inf2012.UseVisualStyleBackColor = true;
            this.inf2012.CheckedChanged += new System.EventHandler(this.inf2012_CheckedChanged);
            // 
            // inf2011
            // 
            this.inf2011.Location = new System.Drawing.Point(214, 67);
            this.inf2011.Name = "inf2011";
            this.inf2011.Size = new System.Drawing.Size(104, 24);
            this.inf2011.TabIndex = 17;
            this.inf2011.TabStop = true;
            this.inf2011.Text = "2011";
            this.inf2011.UseVisualStyleBackColor = true;
            this.inf2011.CheckedChanged += new System.EventHandler(this.inf2011_CheckedChanged);
            // 
            // inf2010
            // 
            this.inf2010.Location = new System.Drawing.Point(214, 43);
            this.inf2010.Name = "inf2010";
            this.inf2010.Size = new System.Drawing.Size(104, 24);
            this.inf2010.TabIndex = 18;
            this.inf2010.TabStop = true;
            this.inf2010.Text = "2010";
            this.inf2010.UseVisualStyleBackColor = true;
            this.inf2010.CheckedChanged += new System.EventHandler(this.inf2010_CheckedChanged);
            // 
            // inf2023
            // 
            this.inf2023.Location = new System.Drawing.Point(418, 110);
            this.inf2023.Name = "inf2023";
            this.inf2023.Size = new System.Drawing.Size(104, 24);
            this.inf2023.TabIndex = 19;
            this.inf2023.TabStop = true;
            this.inf2023.Text = "2023";
            this.inf2023.UseVisualStyleBackColor = true;
            this.inf2023.CheckedChanged += new System.EventHandler(this.inf2023_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Введите количество лет";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(8, 93);
            this.Price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.Price.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(199, 22);
            this.Price.TabIndex = 21;
            this.Price.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Введите стоимость товара";
            // 
            // NewPrice
            // 
            this.NewPrice.Location = new System.Drawing.Point(399, 90);
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.Size = new System.Drawing.Size(198, 22);
            this.NewPrice.TabIndex = 23;
            this.NewPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(399, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Рассчитанная стоимость товара";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NewPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CalcBTN);
            this.groupBox1.Controls.Add(this.ChooseNumber);
            this.groupBox1.Location = new System.Drawing.Point(25, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 164);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.inf2010);
            this.groupBox2.Controls.Add(this.inf2023);
            this.groupBox2.Controls.Add(this.inf2011);
            this.groupBox2.Controls.Add(this.inf2022);
            this.groupBox2.Controls.Add(this.ing2021);
            this.groupBox2.Controls.Add(this.inf2020);
            this.groupBox2.Controls.Add(this.inf2019);
            this.groupBox2.Controls.Add(this.inf2018);
            this.groupBox2.Controls.Add(this.inf2013);
            this.groupBox2.Controls.Add(this.inf2012);
            this.groupBox2.Controls.Add(this.inf2014);
            this.groupBox2.Controls.Add(this.inf2015);
            this.groupBox2.Controls.Add(this.inf2016);
            this.groupBox2.Controls.Add(this.inf2017);
            this.groupBox2.Controls.Add(this.inf2009);
            this.groupBox2.Location = new System.Drawing.Point(850, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 164);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(67, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Выберите год";
            // 
            // Ekaterina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 828);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartCalc);
            this.Controls.Add(this.chartYear);
            this.Controls.Add(this.table);
            this.Name = "Ekaterina";
            this.Text = "Ekaterina";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox NewPrice;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RadioButton inf2019;

        private System.Windows.Forms.RadioButton inf2009;
        private System.Windows.Forms.RadioButton inf2022;
        private System.Windows.Forms.RadioButton ing2021;
        private System.Windows.Forms.RadioButton inf2020;
        private System.Windows.Forms.RadioButton inf2018;
        private System.Windows.Forms.RadioButton inf2017;
        private System.Windows.Forms.RadioButton inf2016;
        private System.Windows.Forms.RadioButton inf2015;
        private System.Windows.Forms.RadioButton inf2014;
        private System.Windows.Forms.RadioButton inf2013;
        private System.Windows.Forms.RadioButton inf2012;
        private System.Windows.Forms.RadioButton inf2011;
        private System.Windows.Forms.RadioButton inf2010;
        private System.Windows.Forms.RadioButton inf2023;

        private System.Windows.Forms.NumericUpDown ChooseNumber;
        private System.Windows.Forms.Button CalcBTN;

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