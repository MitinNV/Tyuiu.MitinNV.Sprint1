using Tyuiu.MitinNV.Sprint1.Task6.V4.Lib;

namespace Tyuiu.MitinNV.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("военнуюутроеннуюупакованную", ds.CheckDoubleN("я пошел сегодня в военную утроенную кафедру, где мне дали упакованную тарелку"));
        }
    }
}