using System.Text.RegularExpressions;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var clearText = Regex.Replace(inputText.Trim().ToLower(), @"\s+", "");
            var stringForCompare = "";

            for (int i = clearText.Length - 1; i >= 0; i--)
            {
                char c = clearText[i];
                stringForCompare += c;
            }

            if (stringForCompare == clearText)
                Console.WriteLine("Введенный текст является палиндромом");

            else
                Console.WriteLine("Введенный текст НЕ является палиндромом");

            Console.ReadKey();
        }
    }
}
