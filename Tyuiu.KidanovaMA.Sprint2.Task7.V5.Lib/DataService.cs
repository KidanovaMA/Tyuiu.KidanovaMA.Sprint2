using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KidanovaMA.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (x >= 0 && y >= x * x && y <= Math.Exp(x)) || (x < 0 && y >= x * x && y <= Math.Exp(-x));
        }
    }
}
