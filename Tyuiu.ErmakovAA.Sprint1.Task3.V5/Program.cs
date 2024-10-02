using Tyuiu.ErmakovAA.Sprint1.Task3.V5.Lib;
namespace Tyuiu.ErmakovAA.Sprint1.Task3.V5
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
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #5                                                                  *");
            Console.WriteLine("* Выполгил: Ермаков А.А.                                                      *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                 *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Введите исходные данные:");
            Console.WriteLine(" Масштаб карты(количество км в одном см)");
            double mapScale;
            mapScale = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Расстояние между точками, изображающими населенные пункты (см)");
            double distanceBetweenPoints;
            distanceBetweenPoints = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine(ds.DistanceLength(mapScale,distanceBetweenPoints));
            Console.ReadLine();
        }

    }
}
