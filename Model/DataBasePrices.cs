using System.Collections.Generic;

namespace LR3.Model
{
    public class DataBasePrices
    {
        private List<Prices> prices = new List<Prices>();

        private Prices i2023 = new Prices(2023, 108119);
        private Prices i2022 = new Prices(2022, 100019);
        private Prices i2021 = new Prices(2021, 91919);
        private Prices i2020 = new Prices(2020, 83819);
        private Prices i2019 = new Prices(2019, 79719);
        private Prices i2018 = new Prices(2018, 75619);
        private Prices i2017 = new Prices(2017, 71519);
        private Prices i2016 = new Prices(2016, 67419);
        private Prices i2015 = new Prices(2015, 63319);
        private Prices i2014 = new Prices(2014, 59219);
        private Prices i2013 = new Prices(2013, 55119);
        private Prices i2012 = new Prices(2012, 49315);
        private Prices i2011 = new Prices(2011, 43511);
        private Prices i2010 = new Prices(2010, 38419);
        private Prices i2009 = new Prices(2009, 34116);

        public List<Prices> GetPrices()
        {
            prices.Add(i2023);
            prices.Add(i2022);
            prices.Add(i2021);
            prices.Add(i2020);
            prices.Add(i2019);
            prices.Add(i2018);
            prices.Add(i2017);
            prices.Add(i2016);
            prices.Add(i2015);
            prices.Add(i2014);
            prices.Add(i2013);
            prices.Add(i2012);
            prices.Add(i2011);
            prices.Add(i2010);
            prices.Add(i2009);
            return prices;
        }
    }
}