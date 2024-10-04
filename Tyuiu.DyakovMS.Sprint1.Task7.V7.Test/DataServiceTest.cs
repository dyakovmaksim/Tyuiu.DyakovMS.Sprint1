using Tyuiu.DyakovMS.Sprint1.Task7.V7.Lib;

namespace Tyuiu.DyakovMS.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double result = ds.Calculate(x, y); 
            Assert.AreEqual(-1.124, result);
        }
    }
}