using Tyuiu.MitinNV.Sprint1.Task4.V25.Lib;

namespace Tyuiu.MitinNV.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.649, ds.Calculate(1));
        }
    }
}