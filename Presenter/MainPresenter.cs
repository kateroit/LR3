using System.Collections.Generic;
using LR3;
using LR3.Model;

namespace LR3.Presenter
{
    public class MainPresenter
    {
        private IFormView view;
        private DataBaseInflation db_Inflations;
        public MainPresenter(IFormView view)
        {
            this.view = view;
            db_Inflations = new DataBaseInflation();
        }
        public List<Inflation> GetInflations()
        {
            return db_Inflations.GetInflations();
        }
    }
}