using Tyuiu.ZaicevYaA.Sprint1.Task7.V24.Lib;
namespace Tyuiu.ZaicevYaA.Sprint1.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Ермаков А.А. | ПКТб-24-1";

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #1                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                *");
            Console.WriteLine("* Задание #7                                                    *");
            Console.WriteLine("* Вариант #24                                                   *");
            Console.WriteLine("* Выполнил : Ермаков А.А.                                       *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение               *");
            Console.WriteLine("* и печатает результат на экране                                *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* (1+(cos(x+1)^1/2)) / (sin(15y - 4))                           *");
            Console.WriteLine("* Введите X                                                     *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y                                                     *");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}