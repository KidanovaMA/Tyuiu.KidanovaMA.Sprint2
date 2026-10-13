using Tyuiu.KidanovaMA.Sprint2.Task5.V11.Lib;

namespace Tyuiu.KidanovaMA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("16.06.2026", ds.FindDateOfNextDay(2026, 6, 15));
            Assert.AreEqual("01.05.2026", ds.FindDateOfNextDay(2026, 4, 30));
            Assert.AreEqual("01.02.2026", ds.FindDateOfNextDay(2026, 1, 31));
            Assert.AreEqual("01.03.2026", ds.FindDateOfNextDay(2026, 2, 28));
            Assert.AreEqual("01.01.2027", ds.FindDateOfNextDay(2026, 12, 31));
        }
    }
}
