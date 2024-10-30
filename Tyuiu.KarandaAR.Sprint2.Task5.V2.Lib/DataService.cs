using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarandaAR.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string season = value switch
            {
                12 or 1 or 2 => "зима",
                3 or 4 or 5 => "весна",
                6 or 7 or 8 => "лето",
                9 or 10 or 11 => "осень",
                _ => "Неизвестный месяц"
            };
            return season;
        }
    }
}
