using Tyuiu.KidanovaMA.Sprint2.Task4.V30.Lib;

namespace Tyuiu.KidanovaMA.Sprint2.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
