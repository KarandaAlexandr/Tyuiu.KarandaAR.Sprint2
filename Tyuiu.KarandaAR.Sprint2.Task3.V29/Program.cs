using Tyuiu.KarandaAR.Sprint2.Task3.V29.Lib;

namespace Tyuiu.KarandaAR.Sprint2.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Условные операторы                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных операторов if-else, где пользователь вводит  *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение       *");
            Console.WriteLine("* до трех знаков после запятой;                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Функция Y определяется следующим образом:                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*              { x * ((x + 1) / (x - 1))^5,           если x > 1          *");
            Console.WriteLine("*              { (x^2 - cos(x^2) + 6) / (x^2 - sin(x^2) + 5), если x = 0  *");
            Console.WriteLine("* Y(x) =       { (1 + (1 / x^2))^x,                  если -33 < x < 2     *");
            Console.WriteLine("*              { x + 10x - (1 / x),                 если x <= -33         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значение X:                                                     *");
            Console.WriteLine("***************************************************************************");

            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Y = {dataService.Calculate(X)}");
        }
    }
}
