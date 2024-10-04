using Tyuiu.DyakovMS.Sprint1.Task3.V2.Lib;

namespace Tyuiu.DyakovMS.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestPurchaseAmount()
        {
            DataService ds = new DataService();
            double priceNotebook = 50;
            int amountNotebook = 2;
            double pricePencil = 10;
            int amountPencil = 2;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(120, res);
        }
    }
}