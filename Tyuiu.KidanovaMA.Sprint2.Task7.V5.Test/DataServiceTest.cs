using Tyuiu.KidanovaMA.Sprint2.Task7.V5.Lib;

namespace Tyuiu.KidanovaMA.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, 2));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, 0.5));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-0.5, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 5));
        }
    }
}
