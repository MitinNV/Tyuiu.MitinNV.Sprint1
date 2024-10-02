using Tyuiu.MitinNV.Sprint1.Task3.V18.Lib;

namespace Tyuiu.MitinNV.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(9, ds.HowManySquares(9, 9, 3));
        }
    }
}