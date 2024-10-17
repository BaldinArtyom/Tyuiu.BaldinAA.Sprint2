using Tyuiu.BaldinAA.Sprint2.Task7.V15.Lib;
namespace Tyuiu.BaldinAA.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.3;
            double y = 1.1;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
        
    
