using Tyuiu.DyakovMS.Sprint1.Task2.V18.Lib;

namespace Tyuiu.DyakovMS.Sprint1.Task2.V18.Test
{
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 2;
            int valueThree = 2;
            var res = ds.CalculateSideSquareParallelepiped(value, valueTwo, valueThree);
            Assert.AreEqual(8, res);
        }
    }
}