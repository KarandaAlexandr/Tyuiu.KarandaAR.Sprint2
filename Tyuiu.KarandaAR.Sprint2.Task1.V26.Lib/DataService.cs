using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarandaAR.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // a = 654, b = 671, c = 874, d = 137
            // ==, !=, <, >, <=, >=
            // |, &, ||, &&, !, ^
            // True, True, True, False, True, False

            bool[] result = new bool[6];

            result[0] = (a == b) | (c > d);
            result[1] = (a < b) & (c > d);
            result[2] = (a <= b) || (c >= d);
            result[3] = (a <= b) && (c <= d);
            result[4] = !result[4];
            result[5] = (a == b) ^ (c < d);

            return result;
        }
    }
}
