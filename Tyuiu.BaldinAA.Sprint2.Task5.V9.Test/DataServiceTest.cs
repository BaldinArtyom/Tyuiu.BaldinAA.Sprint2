using Tyuiu.BaldinAA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.BaldinAA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("1.12", ds.FindDateOfNextDay(30, 11));
        }
    }
}