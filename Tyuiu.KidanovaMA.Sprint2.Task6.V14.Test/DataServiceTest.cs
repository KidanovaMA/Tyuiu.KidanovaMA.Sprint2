using Tyuiu.KidanovaMA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.KidanovaMA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
            Assert.AreEqual("Понедельник", ds.FindDayName(8, 1));
            Assert.AreEqual("Пятница", ds.FindDayName(6, 7));
        }
    }
}
