using Tyuiu.DyakovMS.Sprint1.Task5.V4.Lib;
namespace Tyuiu.DyakovMS.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Преобразование типов и класс Convert                                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая решает следующую задачу: Идет k-я секунда сут*");
            Console.WriteLine("*ток. Определить, сколько полных часов (h) прошло к этому моменту (наприме*");
            Console.WriteLine("*ер, h=3, если k=13257).                                                  *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Введите секунды: ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.SecondsToHours(time);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}