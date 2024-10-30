using Tyuiu.KarandaAR.Sprint2.Task7.V14.Lib;

namespace Tyuiu.KarandaAR.Sprint2.Task7.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();


            Console.Title = "Спринт #2 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции с координатами                                           *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X, Y в заштрихованной области.                                          *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y");
            double y = Convert.ToDouble(Console.ReadLine());

            bool pointInShadedArea = dataService.CheckDotInShadedArea(x, y);
            if (pointInShadedArea)
            {
                Console.WriteLine($"Точка ({(x)}, {y}) находится в закрашенной области.");
            }
            else
            {
                Console.WriteLine($"Точка ({(x)}, {y}) находится вне закрашенной области.");
            }

            Console.ReadKey();
        }
    }
}
