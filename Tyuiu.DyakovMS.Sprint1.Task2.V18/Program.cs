using Tyuiu.DyakovMS.Sprint1.Task2.V18.Lib;
namespace Tyuiu.DyakovMS.Sprint1.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Арифметические операторы в C#                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, в*");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value;
            int valueTwo;
            int valueThree;

            Console.WriteLine("Введите длину параллелепипеда: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину параллелепипеда: ");
            valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту параллелепипеда: ");
            valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Площадь боковой поверхности параллелепипеда = " + ds.CalculateSideSquareParallelepiped(value, valueTwo, valueThree));
            Console.ReadKey();
        }
    }
}