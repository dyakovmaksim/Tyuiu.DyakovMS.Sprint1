using Tyuiu.DyakovMS.Sprint1.Task0.V1.Lib;

namespace Tyuiu.DyakovMS.Sprint1.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();  
            var res = ds.Calculate();
            Assert.AreEqual(-6, res);
        }
    }
}