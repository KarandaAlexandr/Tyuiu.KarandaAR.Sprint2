using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarandaAR.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] array = { x == y + 800, x != y + 800, y < x, y < x, y <= x, y >= x };
            return array;
        }
    }
}
