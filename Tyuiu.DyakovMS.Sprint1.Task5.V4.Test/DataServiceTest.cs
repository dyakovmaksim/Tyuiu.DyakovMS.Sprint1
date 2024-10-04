using Tyuiu.DyakovMS.Sprint1.Task5.V4.Lib;

namespace Tyuiu.DyakovMS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSecondsToHours()
        {
            DataService ds = new DataService();
            int time = 17000;
            int hours = ds.SecondsToHours(time);
            Assert.AreEqual(4, hours);
        }
    }
}