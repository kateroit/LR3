namespace LR3.Model
{
    public class Inflation
    {
        public int Year;
        public double January, February, March, April, May, June, July, August, September, October, November, December;

        public Inflation(int year, double january, double february, double march, double april, double may, double june, double july, double august, double september, double october, double november, double december)
        {
            Year = year;
            January = january;
            February = february;
            March = march;
            April = april;
            May = may;
            June = june;
            July = july;
            August = august;
            September = september;
            October = october;
            November = november;
            December = december;
        }
    }
}