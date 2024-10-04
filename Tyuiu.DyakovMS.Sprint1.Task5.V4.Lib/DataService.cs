using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DyakovMS.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            double hours = time / 60 / 60;
            return (int)Math.Floor(hours);
        }
    }
}
