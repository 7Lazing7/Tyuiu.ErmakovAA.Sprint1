using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ErmakovAA.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            return Math.Round(value * 0.393701,3);
        }
    }

}
