using Tyuiu.MitinNV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MitinNV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();             
            Assert.AreEqual(0, ds.FahrenheitToСelsius(32));
        }
    }
}