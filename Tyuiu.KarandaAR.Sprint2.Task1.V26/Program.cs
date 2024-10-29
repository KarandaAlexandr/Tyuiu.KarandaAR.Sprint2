using Tyuiu.KarandaAR.Sprint2.Task1.V26.Lib;

namespace Tyuiu.KarandaAR.Sprint2.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;

            bool[] A = dataService.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Каранда Александр РОманович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций          *");
            Console.WriteLine("* ==, !=, <, >, <=, >= последовательность можно чередовать                *");
            Console.WriteLine("* |, &, ||, &&, ! последовательность операций не должна нарушаться        *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
            Console.WriteLine("* (массив): (True, True, True, False, True, False)                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadKey();
        }
    }
}
