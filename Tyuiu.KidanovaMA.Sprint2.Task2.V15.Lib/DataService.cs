using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KidanovaMA.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            if ((y >= 3 && y <= 4 && x >= 6 - y && x <= 5) || (y >= 5 && y <= 7 && x >= 2 && x <= 13) || (y >= 3 && y <= 11 && x >= 9 && x <= 13) || (y >= 12 && y <= 13 && x > 9 && x <= 13 - (y - 11)) || (y == 8 && x >= 2 && x <= 4) || (y == 9 && x >= 4 && x <= 7) || (y == 10 && x >= 5 && x <= 7) || (y == 11 && x >= 5 && x <= 6) || (y == 12 && x >= 4 && x <= 5) || (y == 13 && x >= 2 && x <= 4))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
