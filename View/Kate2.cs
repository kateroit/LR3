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
    public partial class Kate2 : Form, IFormView
    {
        private MainPresenter presenter;
        public Kate2()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
            GetValues();
        }
        
        // Заполнение таблицы
        private void GetValues()
        {
            var prices = presenter.GetPrices();
            for (int i = 0; i <= 14; i++)
            {
                if (i <= 13)
                {
                    table.Rows.Add();
                }
                table.Rows[i].Cells[0].Value = prices[i].Year;
                table.Rows[i].Cells[1].Value = prices[i].Price;
            }
        }

        private void CalcBTN_Click(object sender, EventArgs e)
        {
            var prices = presenter.GetPrices();
            List<double> pri = new List<double>();
            
            for (int i = 0; i < 15; i++)
            {
                pri.Add(prices[i].Price);
            }
            
            for (int i = (int)ChooseNumber.Value; i > 0; i--)
            {
                double k = 0;
                for (int j = (int)ChooseNumber.Value; j > 0; j--)
                {
                    k += pri[pri.Count - j];
                }
                double avg = k / (double)ChooseNumber.Value;
                pri.Add(avg);
            }
            this.chartCalc.Series[0].Points.Clear();
            int mounth = 1;
            for (int i = 0; i < 15 + ChooseNumber.Value; i++)
            {
                this.chartCalc.Series[0].Points.AddXY(mounth, pri[i]);
                mounth++;
            }
            pri.Clear();
        }
        private void inf2009_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2010_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2011_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2012_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2013_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2014_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2015_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2016_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2017_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2018_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2019_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2020_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ing2021_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2022_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void inf2023_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}