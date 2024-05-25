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
            Chart();
        }
        // Построение графика изменения цен по годам
        private void Chart()
        {
            var prices = presenter.GetPrices();
            this.chartYear.Series[0].Points.Clear();
            int mounth = 1;
            for (int i = 0; i < 15; i++)
            {
                this.chartYear.Series[0].Points.AddXY(mounth, prices[i].Price);
                mounth++;
            }
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

        private void CalcRooms_Click(object sender, EventArgs e)
        {
            var prices = presenter.GetPrices();
            List<int> pri = new List<int>();
            switch ((int)ChooseRooms.Value)
            {
                case 1:
                    for (int i = 0; i < 15; i++)
                    {
                        pri.Add(prices[i].Price * 30);
                    }
                    break;
                case 2:
                    for (int i = 0; i < 15; i++)
                    {
                        pri.Add(prices[i].Price * 60);
                    }
                    break;
                case 3:
                    for (int i = 0; i < 15; i++)
                    {
                        pri.Add(prices[i].Price * 90);
                    }
                    break;
                case 4:
                    for (int i = 0; i < 15; i++)
                    {
                        pri.Add(prices[i].Price * 120);
                    }
                    break;
                case 5:
                    for (int i = 0; i < 15; i++)
                    {
                        pri.Add(prices[i].Price * 150);
                    }
                    break;
            }
            
            for (int i = 0; i < 15; i++)
            {
                pri.Add((int)ChooseRooms.Value * prices[i].Price);
            }
            PriceRooms.Text = "Стоимость " + ChooseNumber.Value + "-ой квартиры составляет:\n";
            for (int i = 0; i < 15; i++)
            {
                PriceRooms.Text += "В " + prices[i].Year + " году - " + pri[i] + " рублей\n";
            }
            pri.Clear();
        }
    }
}