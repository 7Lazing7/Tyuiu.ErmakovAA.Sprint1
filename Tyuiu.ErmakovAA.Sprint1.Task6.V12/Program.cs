using Tyuiu.ErmakovAA.Sprint1.Task6.V12.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task6.V12
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
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #6                                                                  *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                      *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                    *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Введите исходные данные:");
            Console.WriteLine("Введите исходные число k (от 1 до 365)");
            string value;
            value = Convert.ToString(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.CheckLastWordRepetiton(value));
            Console.ReadLine();
        }

    }
}