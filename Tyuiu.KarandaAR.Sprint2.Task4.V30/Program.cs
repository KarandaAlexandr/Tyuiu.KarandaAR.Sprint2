using Tyuiu.KarandaAR.Sprint2.Task4.V30.Lib;

namespace Tyuiu.KarandaAR.Sprint2.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарные операторы                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение Z              *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит          *");
            Console.WriteLine("* переменные X, Y. Ответ округлить до 3-х знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Z = {dataService.Calculate(x, y)}");
        }
    }
}
