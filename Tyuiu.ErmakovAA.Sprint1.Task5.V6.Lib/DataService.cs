using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ErmakovAA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
           return Convert.ToInt32(k / 365);
        }
    }

}
