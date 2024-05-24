using System.Collections.Generic;

namespace LR3.Model
{
    public class DataBaseInflation
    {
        List<Inflation> inflationList = new List<Inflation>();
        
        private Inflation i2023 =
            new Inflation(2023, 11.76, 10.97, 3.51, 2.30, 2.5, 
                3.24, 4.3, 5.13, 6, 6.68, 7.47, 7.42);
        private Inflation i2022 = 
            new Inflation(2022, 8.74, 9.16, 16.70, 17.83, 17.11,
                15.90, 15.09, 14.30, 13.67, 12.63, 11.97, 11.92);
        private Inflation i2021 =
            new Inflation(2021, 5.19, 5.67, 5.78, 5.52, 6.01,
                6.51, 6.47, 6.69, 7.41, 8.14, 8.40, 8.39);
        private Inflation i2020 = 
            new Inflation(2020, 2.42, 2.31, 2.55, 3.10, 3.03,
            3.21, 3.37, 3.57, 3.67, 3.98, 4.42, 4.91);
        private Inflation i2019 = 
            new Inflation(2019, 5.00, 5.24, 5.27, 5.17, 5.13,
            4.66, 4.59, 4.33, 3.99, 3.77, 3.54, 3.05);
        private Inflation i2018 = 
            new Inflation(2018, 2.21,	2.20,	2.36,	2.41,	2.42,
            2.30,	2.50,	3.07,	3.39,	3.55,	3.83,	4.27);
        private Inflation i2017 = 
            new Inflation(2017, 5.02,	4.59,4.25,	4.13,	4.09,
            4.35,	3.86,	3.29,	2.96,	2.73,	2.50,	2.52);
        private Inflation i2016 = 
            new Inflation(2016, 9.77,	8.06,	7.26,7.24, 7.30,
            7.48,	7.21,	6.84,	6.42,	6.09,	5.76,	5.38);
        private Inflation i2015 = 
            new Inflation(2015, 14.97,	16.71,	16.93,	16.42,	15.78,
                15.29,	15.64,	15.77,	15.68,	15.59,	14.98,	12.91);
        private Inflation i2014 = 
            new Inflation(2014, 6.05,	6.20,	6.92,	7.33,	7.59,
                7.80,	7.45,	7.56,	8.03,	8.30,	9.07,	11.36);
        private Inflation i2013 = 
            new Inflation(2013, 7.07,	7.28,	7.02,	7.23,	7.38,
                6.88,	6.45,	6.49,	6.13,	6.25,	6.48,	6.45);
        private Inflation i2012 = 
            new Inflation(2012, 4.16,	3.74,	3.70,	3.57,	3.61,
                4.30,	5.59,	5.95,	6.58,	6.55,	6.47,	6.58);
        private Inflation i2011 = 
            new Inflation(2011, 9.56,	9.47,	9.46,	9.61,	9.59,
                9.42,	9.01,	8.16,	7.21,	7.19,	6.78,	6.10);
        private Inflation i2010 = 
            new Inflation(2010, 8.02,	7.18,	6.46,	6.04,	5.97,
                5.74,	5.46,	6.04,	6.96,	7.50,	8.06,	8.78);
        private Inflation i2009 = 
            new Inflation(2009, 13.35,	13.85,	13.98, 13.16,	12.28,
                11.87,	12.01,	11.60,	10.69,	9.69,	9.10,	8.80);

        public List<Inflation> GetInflations()
        {
            inflationList.Add(i2023);
            inflationList.Add(i2022);
            inflationList.Add(i2021);
            inflationList.Add(i2020);
            inflationList.Add(i2019);
            inflationList.Add(i2018);
            inflationList.Add(i2017);
            inflationList.Add(i2016);
            inflationList.Add(i2015);
            inflationList.Add(i2014);
            inflationList.Add(i2013);
            inflationList.Add(i2012);
            inflationList.Add(i2011);
            inflationList.Add(i2010);
            inflationList.Add(i2009);
            return inflationList;
        }
    }
}