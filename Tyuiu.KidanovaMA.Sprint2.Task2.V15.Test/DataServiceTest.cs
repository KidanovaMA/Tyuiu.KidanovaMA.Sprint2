using Tyuiu.KidanovaMA.Sprint2.Task2.V15.Lib;

namespace Tyuiu.KidanovaMA.Sprint2.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
