using Tyuiu.KarandaAR.Sprint2.Task6.V1.Lib;

namespace Tyuiu.KarandaAR.Sprint2.Task6.V1
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch, вычисляет требуемое значение и возвращает результат.  *");
            Console.WriteLine("* По данному номеру месяца, определите количество дней в этом месяце.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите номер месяца (1-12):                                            *");
            Console.WriteLine("***************************************************************************");

            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Месяц {month} содержит {dataService.FindMonthDaysCount(month)} дней.");

            Console.ReadKey();
        }
    }
}
