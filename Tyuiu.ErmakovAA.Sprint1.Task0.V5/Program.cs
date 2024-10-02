//Задание 
//Написать программу, которая вычисляет выражение 10 / (2 + 3) и печатает результат на эеране.

using Tyuiu.ErmakovAA.Sprint1.Task0.V5.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            // Длина  строки 75 символов
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                 *");
            Console.WriteLine("* Задание #0                                                                  *");
            Console.WriteLine("* Вариант #5                                                                  *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                      *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)                *");
            Console.WriteLine("* и печатает результат на эеране.                                             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* 10 / (2 + 3)                                                                *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.ErmakovAA.Sprint1.Task0.V0.Lib;
            // в классе DataService
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }

    }
}


        

