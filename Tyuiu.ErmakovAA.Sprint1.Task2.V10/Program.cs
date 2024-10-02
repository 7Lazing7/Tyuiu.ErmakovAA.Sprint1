using Tyuiu.ErmakovAA.Sprint1.Task2.V10.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task2.V10
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
            Console.WriteLine("* Задание #2                                                                  *");
            Console.WriteLine("* Вариант #10                                                                  *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                      *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                 *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Введите значение в метрах (целое число)");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine(ds.ConvertMetreToInchs(x));
            Console.ReadLine();
        }

    }
}
