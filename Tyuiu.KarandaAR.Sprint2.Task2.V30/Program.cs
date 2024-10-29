using Tyuiu.KarandaAR.Sprint2.Task2.V30.Lib;

namespace Tyuiu.KarandaAR.Sprint2.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной     *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("************************ Заштрихованная область ***************************");

            int[,] matrix = new int[,]
            {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 1
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, // 2
            { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, // 3
            { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, // 4
            { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, // 5
            { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, // 6
            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, // 7
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("* ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] == 1 ? "■ " : "  ");
                }
                Console.WriteLine("                                          *");
            }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты точки (X и Y):");
            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool isDotInArea = ds.CheckDotInShadedArea(x, y);

            if (isDotInArea)
            {
                Console.WriteLine($"Точка ({x}, {y}) находится в закрашеной области.");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) находится вне закрашеной области.");
            }

            Console.ReadKey();

        }
    }
}

