using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarandaAR.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка на принадлежность единичной окружности
            if (x * x + y * y > 1)
                return false;

            // Первая и четвертая четверти
            if (x >= 0)
                return true;

            // Промежуток от 90° до 135°
            // Проверка для второй четверти: x < 0 и y > 0
            // и промежуток угла: y должен быть >= √2/2 (приблизительно 0.707)
            if (x < 0 && y > 0 && y >= Math.Sqrt(2) / 2)
                return true;

            return false;
        }
    }
}
