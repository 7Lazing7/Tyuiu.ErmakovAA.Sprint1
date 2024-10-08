using System.Net.Security;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ErmakovAA.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            // Убираем лишние пробелы в начале и конце строки
            value = value.Trim();

            // Разбиваем текст на слова
            var words = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Если слов нет, возвращаем false
            if (words.Length == 0)
            {
                return false;
            }

            // Получаем последнее слово
            string lastWord = words[^1]; // Используем индексацию с конца

            // Проверяем, встречается ли последнее слово в строке еще раз
            int lastWordCount = 0;
            foreach (var word in words)
            {
                if (word.Equals(lastWord, StringComparison.OrdinalIgnoreCase))
                {
                    lastWordCount++;
                }
            }

            // Если найдено больше одного вхождения, возвращаем true
            return lastWordCount > 1;
        }
    }
}








