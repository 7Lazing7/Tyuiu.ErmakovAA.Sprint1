using System.Net.Security;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ErmakovAA.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string[] words = input.Split(' ');
            string lastWord = words[words.Length - 1];

            bool appearsAgain = words.Take(words.Length - 1).Any(w => w.Equals(lastWord, StringComparison.OrdinalIgnoreCase));

            if (appearsAgain)
            {
                Console.WriteLine($"Последнее слово \"{lastWord}\" входит в строку еще раз.");
            }
            else
            {
                Console.WriteLine($"Последнее слово \"{lastWord}\" не входит в строку еще раз.");
            }

        }
    }
}

   
     

           

