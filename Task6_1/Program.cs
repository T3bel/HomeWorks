using System.Text.RegularExpressions;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var splitText = Regex.Split(inputText.Trim(),@"\s+");

            for (int i = 0; i < splitText.Length - 1; i++)
            {
                for (int j = 0; j < splitText.Length - i - 1; j++)
                {
                    if (splitText[j].Length > splitText[j + 1].Length)
                    {
                        string value = splitText[j];
                        splitText[j] = splitText[j + 1];
                        splitText[j + 1] = value;
                    }
                }
            }

            Console.WriteLine($"Самое длинное слово: {splitText[splitText.Length - 1]}");
            Console.ReadKey();
        }
    }
}
