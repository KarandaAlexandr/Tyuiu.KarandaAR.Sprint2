using Tyuiu.KarandaAR.Sprint2.Task5.V2.Lib;

namespace Tyuiu.KarandaAR.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch для вычисления   *");
            Console.WriteLine("* требуемого значения и возвращает результат. По данному месяцу, определите*");
            Console.WriteLine("* в какую пору года попадает этот месяц (Зима, Лето, Весна, Осень).       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите номер месяца (1-12):                                            *");
            Console.WriteLine("***************************************************************************");

            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Месяц {month} относится к времени года: {dataService.FindMonthSeason(month)}");

            Console.ReadKey();
        }
    }
}
