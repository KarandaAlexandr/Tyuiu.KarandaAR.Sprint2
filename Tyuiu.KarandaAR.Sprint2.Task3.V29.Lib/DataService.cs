using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarandaAR.Sprint2.Task3.V29.Lib
{
    public class DataService : ISprint2Task3V29
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(x * Math.Pow((x + 1) / (x - 1), 5), 3);
            }
            else if (x == 0)
            {
                return Math.Round((x * x - Math.Cos(x * x) + 6) / (x * x - Math.Sin(x * x) + 5), 3);
            }
            else if (-33 < x && x < 2)
            {
                return Math.Round(Math.Pow(1 + (1 / x * x), x), 3);
            }
            else
            {
                return Math.Round(x + 10 * x - (1 / x), 3);
            }
        }
    }
}
