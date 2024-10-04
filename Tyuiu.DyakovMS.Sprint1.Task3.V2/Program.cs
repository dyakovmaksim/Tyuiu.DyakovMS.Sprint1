using Tyuiu.DyakovMS.Sprint1.Task3.V2.Lib;
namespace Tyuiu.DyakovMS.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Операторы составного присваивания                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, в*");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите цену тетрадей: ");
            double priceNotebook = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во тетрадей: ");
            int amountNotebook = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену карандашей: ");
            double pricePencil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во карандашей: ");
            int amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Console.WriteLine("Стоимость вашей покупки: " + result);
            Console.ReadKey();
        }
    }
}