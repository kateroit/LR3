using System.Collections.Generic;
using LR3;
using LR3.Model;

namespace LR3.Presenter
{
    public class MainPresenter
    {
        private IFormView view;
        private DataBaseInflation db_Inflations;
        private DataBasePrices db_Prices;
        public MainPresenter(IFormView view)
        {
            this.view = view;
            db_Inflations = new DataBaseInflation();
            db_Prices = new DataBasePrices();
        }
        public List<Inflation> GetInflations()
        {
            return db_Inflations.GetInflations();
        }

        public List<Prices> GetPrices()
        {
            return db_Prices.GetPrices();
        }
    }
}