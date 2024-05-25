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
    }
}