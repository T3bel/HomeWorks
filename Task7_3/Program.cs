using System.Collections.Immutable;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите числа через запятую для вывода массива");
                    int[] numbers = Console.ReadLine().Split(',').Select(x =>
                    {
                        if (int.TryParse(x, out int xInt)) return xInt;
                        return 0;
                    }
                    ).ToArray<int>();
                    Console.WriteLine(@"Нужно ли вывести их в обратном порядке? Да\Нет");
                    var inputBoolText = Console.ReadLine().ToLower().Trim();
                    var reverse = inputBoolText == "да" ? true : inputBoolText == "нет" ? false : throw new FormatException("Введите Да или Нет");
                    PrintNumbers(numbers, reverse);
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (!reverse)
            {

                for (int i = 0; i <= numbers.Length - 1; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

            }
            else if (reverse)
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

        }
    }
}

