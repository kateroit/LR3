using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using LR3.Presenter;
using System.Windows.Forms.DataVisualization.Charting;
using LR3.Model;
using static System.Windows.Forms.DataVisualization.Charting.SeriesChartType;

namespace LR3
{
    public partial class Ekaterina : Form, IFormView
    {
        private MainPresenter presenter;
        public Ekaterina()
        {
            InitializeComponent();
            
            presenter = new MainPresenter(this);
            GetValues();
        }
        // Заполнение таблицы
        private void GetValues()
        {
            var inflationList = presenter.GetInflations();
            for (int i = 0; i <= 14; i++)
            {
                if (i <= 13)
                {
                    table.Rows.Add();
                }
                table.Rows[i].Cells[0].Value = inflationList[i].Year;
                table.Rows[i].Cells[1].Value = inflationList[i].January;
                table.Rows[i].Cells[2].Value = inflationList[i].February;
                table.Rows[i].Cells[3].Value = inflationList[i].March;
                table.Rows[i].Cells[4].Value = inflationList[i].April;
                table.Rows[i].Cells[5].Value = inflationList[i].May;
                table.Rows[i].Cells[6].Value = inflationList[i].June;
                table.Rows[i].Cells[7].Value = inflationList[i].July;
                table.Rows[i].Cells[8].Value = inflationList[i].August;
                table.Rows[i].Cells[9].Value = inflationList[i].September;
                table.Rows[i].Cells[10].Value = inflationList[i].October;
                table.Rows[i].Cells[11].Value = inflationList[i].November;
                table.Rows[i].Cells[12].Value = inflationList[i].December;
            }
        }
        
        // Вычисление экстраполяции
        private void CalcBTN_Click(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            List<double> inf = new List<double>();
            
            for (int i = 0; i < 15; i++)
            {
                inf.Add(inflationList[i].December);
            }
            
            for (int i = (int)ChooseNumber.Value; i > 0; i--)
            {
                double k = 0;
                for (int j = (int)ChooseNumber.Value; j > 0; j--)
                {
                    k += inf[inf.Count - j];
                }
                double avg = k / (double)ChooseNumber.Value;
                inf.Add(avg);
            }
            this.chartCalc.Series[0].Points.Clear();
            int mounth = 1;
            for (int i = 0; i < 15 + ChooseNumber.Value; i++)
            {
                this.chartCalc.Series[0].Points.AddXY(mounth, inf[i]);
                mounth++;
            }

            double price = (double)Price.Value;
            double _ = price * Math.Pow((1 + ((inf[inf.Count - 1]) / 100)), (double)ChooseNumber.Value);
            int newPrice = (int)_;
            NewPrice.Text = newPrice.ToString();
            inf.Clear();
        }
        // Графики по годам
        private void inf2009_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[0].January);
            infMounth.Add(inflationList[0].February);
            infMounth.Add(inflationList[0].March);
            infMounth.Add(inflationList[0].April);
            infMounth.Add(inflationList[0].May);
            infMounth.Add(inflationList[0].June);
            infMounth.Add(inflationList[0].July);
            infMounth.Add(inflationList[0].August);
            infMounth.Add(inflationList[0].September);
            infMounth.Add(inflationList[0].October);
            infMounth.Add(inflationList[0].November);
            infMounth.Add(inflationList[0].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2010_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[1].January);
            infMounth.Add(inflationList[1].February);
            infMounth.Add(inflationList[1].March);
            infMounth.Add(inflationList[1].April);
            infMounth.Add(inflationList[1].May);
            infMounth.Add(inflationList[1].June);
            infMounth.Add(inflationList[1].July);
            infMounth.Add(inflationList[1].August);
            infMounth.Add(inflationList[1].September);
            infMounth.Add(inflationList[1].October);
            infMounth.Add(inflationList[1].November);
            infMounth.Add(inflationList[1].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2011_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[2].January);
            infMounth.Add(inflationList[2].February);
            infMounth.Add(inflationList[2].March);
            infMounth.Add(inflationList[2].April);
            infMounth.Add(inflationList[2].May);
            infMounth.Add(inflationList[2].June);
            infMounth.Add(inflationList[2].July);
            infMounth.Add(inflationList[2].August);
            infMounth.Add(inflationList[2].September);
            infMounth.Add(inflationList[2].October);
            infMounth.Add(inflationList[2].November);
            infMounth.Add(inflationList[2].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2012_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[3].January);
            infMounth.Add(inflationList[3].February);
            infMounth.Add(inflationList[3].March);
            infMounth.Add(inflationList[3].April);
            infMounth.Add(inflationList[3].May);
            infMounth.Add(inflationList[3].June);
            infMounth.Add(inflationList[3].July);
            infMounth.Add(inflationList[3].August);
            infMounth.Add(inflationList[3].September);
            infMounth.Add(inflationList[3].October);
            infMounth.Add(inflationList[3].November);
            infMounth.Add(inflationList[3].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2013_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[4].January);
            infMounth.Add(inflationList[4].February);
            infMounth.Add(inflationList[4].March);
            infMounth.Add(inflationList[4].April);
            infMounth.Add(inflationList[4].May);
            infMounth.Add(inflationList[4].June);
            infMounth.Add(inflationList[4].July);
            infMounth.Add(inflationList[4].August);
            infMounth.Add(inflationList[4].September);
            infMounth.Add(inflationList[4].October);
            infMounth.Add(inflationList[4].November);
            infMounth.Add(inflationList[4].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2014_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[5].January);
            infMounth.Add(inflationList[5].February);
            infMounth.Add(inflationList[5].March);
            infMounth.Add(inflationList[5].April);
            infMounth.Add(inflationList[5].May);
            infMounth.Add(inflationList[5].June);
            infMounth.Add(inflationList[5].July);
            infMounth.Add(inflationList[5].August);
            infMounth.Add(inflationList[5].September);
            infMounth.Add(inflationList[5].October);
            infMounth.Add(inflationList[5].November);
            infMounth.Add(inflationList[5].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2015_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[6].January);
            infMounth.Add(inflationList[6].February);
            infMounth.Add(inflationList[6].March);
            infMounth.Add(inflationList[6].April);
            infMounth.Add(inflationList[6].May);
            infMounth.Add(inflationList[6].June);
            infMounth.Add(inflationList[6].July);
            infMounth.Add(inflationList[6].August);
            infMounth.Add(inflationList[6].September);
            infMounth.Add(inflationList[6].October);
            infMounth.Add(inflationList[6].November);
            infMounth.Add(inflationList[6].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2016_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[7].January);
            infMounth.Add(inflationList[7].February);
            infMounth.Add(inflationList[7].March);
            infMounth.Add(inflationList[7].April);
            infMounth.Add(inflationList[7].May);
            infMounth.Add(inflationList[7].June);
            infMounth.Add(inflationList[7].July);
            infMounth.Add(inflationList[7].August);
            infMounth.Add(inflationList[7].September);
            infMounth.Add(inflationList[7].October);
            infMounth.Add(inflationList[7].November);
            infMounth.Add(inflationList[7].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2017_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[8].January);
            infMounth.Add(inflationList[8].February);
            infMounth.Add(inflationList[8].March);
            infMounth.Add(inflationList[8].April);
            infMounth.Add(inflationList[8].May);
            infMounth.Add(inflationList[8].June);
            infMounth.Add(inflationList[8].July);
            infMounth.Add(inflationList[8].August);
            infMounth.Add(inflationList[8].September);
            infMounth.Add(inflationList[8].October);
            infMounth.Add(inflationList[8].November);
            infMounth.Add(inflationList[8].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2018_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[9].January);
            infMounth.Add(inflationList[9].February);
            infMounth.Add(inflationList[9].March);
            infMounth.Add(inflationList[9].April);
            infMounth.Add(inflationList[9].May);
            infMounth.Add(inflationList[9].June);
            infMounth.Add(inflationList[9].July);
            infMounth.Add(inflationList[9].August);
            infMounth.Add(inflationList[9].September);
            infMounth.Add(inflationList[9].October);
            infMounth.Add(inflationList[9].November);
            infMounth.Add(inflationList[9].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2019_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[10].January);
            infMounth.Add(inflationList[10].February);
            infMounth.Add(inflationList[10].March);
            infMounth.Add(inflationList[10].April);
            infMounth.Add(inflationList[10].May);
            infMounth.Add(inflationList[10].June);
            infMounth.Add(inflationList[10].July);
            infMounth.Add(inflationList[10].August);
            infMounth.Add(inflationList[10].September);
            infMounth.Add(inflationList[10].October);
            infMounth.Add(inflationList[10].November);
            infMounth.Add(inflationList[10].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2020_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[11].January);
            infMounth.Add(inflationList[11].February);
            infMounth.Add(inflationList[11].March);
            infMounth.Add(inflationList[11].April);
            infMounth.Add(inflationList[11].May);
            infMounth.Add(inflationList[11].June);
            infMounth.Add(inflationList[11].July);
            infMounth.Add(inflationList[11].August);
            infMounth.Add(inflationList[11].September);
            infMounth.Add(inflationList[11].October);
            infMounth.Add(inflationList[11].November);
            infMounth.Add(inflationList[11].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void ing2021_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[12].January);
            infMounth.Add(inflationList[12].February);
            infMounth.Add(inflationList[12].March);
            infMounth.Add(inflationList[12].April);
            infMounth.Add(inflationList[12].May);
            infMounth.Add(inflationList[12].June);
            infMounth.Add(inflationList[12].July);
            infMounth.Add(inflationList[12].August);
            infMounth.Add(inflationList[12].September);
            infMounth.Add(inflationList[12].October);
            infMounth.Add(inflationList[12].November);
            infMounth.Add(inflationList[12].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2022_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[13].January);
            infMounth.Add(inflationList[13].February);
            infMounth.Add(inflationList[13].March);
            infMounth.Add(inflationList[13].April);
            infMounth.Add(inflationList[13].May);
            infMounth.Add(inflationList[13].June);
            infMounth.Add(inflationList[13].July);
            infMounth.Add(inflationList[13].August);
            infMounth.Add(inflationList[13].September);
            infMounth.Add(inflationList[13].October);
            infMounth.Add(inflationList[13].November);
            infMounth.Add(inflationList[13].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }

        private void inf2023_CheckedChanged(object sender, EventArgs e)
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            List<double> infMounth = new List<double>();
            infMounth.Add(inflationList[14].January);
            infMounth.Add(inflationList[14].February);
            infMounth.Add(inflationList[14].March);
            infMounth.Add(inflationList[14].April);
            infMounth.Add(inflationList[14].May);
            infMounth.Add(inflationList[14].June);
            infMounth.Add(inflationList[14].July);
            infMounth.Add(inflationList[14].August);
            infMounth.Add(inflationList[14].September);
            infMounth.Add(inflationList[14].October);
            infMounth.Add(inflationList[14].November);
            infMounth.Add(inflationList[14].December);
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, infMounth[i]);
                mounth++;
            }
        }
    }
}