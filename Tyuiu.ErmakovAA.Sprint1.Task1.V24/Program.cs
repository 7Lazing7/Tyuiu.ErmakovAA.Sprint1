using Tyuiu.ErmakovAA.Sprint1.Task1.V24.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task1.V24

//Задание 
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле (1-x)/(2+y) и печатает его на экране.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполгил: Ермаков А.А. | ПКТб-24-1";
           
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                 *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #24                                                                 *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                      *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (1 - x) / (2 + y)           *");
            Console.WriteLine("* и печатает результат на эеране.                                             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* (1 - x) / (2 + y)                                                           *");
            Console.WriteLine("*******************************************************************************");
           
            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }

    }
}






