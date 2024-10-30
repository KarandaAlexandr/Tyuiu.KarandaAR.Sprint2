using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarandaAR.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindMonthDaysCount(int value)
        {
            int days = value switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => -1 // некорректный номер месяца
            };
            return days;
        }
    }
}
