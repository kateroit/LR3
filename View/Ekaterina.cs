using System;
using System.Windows.Forms;
using LR3.Presenter;
using System.Windows.Forms.DataVisualization.Charting;
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
            Chart();
        }
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

        private void Chart()
        {
            var inflationList = presenter.GetInflations();
            this.chartYear.Series[0].Points.Clear();
            int mounth = 1;
            for (int i = 0; i < 12; i++)
            {
                double inflation = inflationList[i].December;
                this.chartYear.Series[0].Points.AddXY(mounth, inflation);
                mounth++;
            }
        }
    }
}