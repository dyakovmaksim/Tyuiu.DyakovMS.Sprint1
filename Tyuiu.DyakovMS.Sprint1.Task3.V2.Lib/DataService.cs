using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DyakovMS.Sprint1.Task3.V2.Lib
{
    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double priceNotebook, int amountNotebook, double pricePencil, int amountPencil)
        {
            double result = priceNotebook * amountNotebook + pricePencil * amountPencil;
            return Math.Round(result, 3);
        }
    }
}
