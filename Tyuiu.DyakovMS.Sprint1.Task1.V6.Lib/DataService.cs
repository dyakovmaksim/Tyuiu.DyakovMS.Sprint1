using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DyakovMS.Sprint1.Task1.V6.Lib
{
    public class DataService : ISprint1Task1V6
    {
        public double Calculate(double x, double y)
        {
            return (x + y) / (3 * y);
        }
    }
}
