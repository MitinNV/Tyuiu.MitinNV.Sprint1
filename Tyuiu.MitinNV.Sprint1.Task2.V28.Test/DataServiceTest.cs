using Tyuiu.MitinNV.Sprint1.Task2.V28.Lib;

namespace Tyuiu.MitinNV.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            Assert.AreEqual(288, ds.ConvertCelsiusToKelvin(15));
        }
    }
}