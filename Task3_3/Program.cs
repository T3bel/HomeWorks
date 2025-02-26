namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У вас больше 4 чисел для сравнения? Y/N");
            //var key = Console.ReadKey(true).Key;
            int maxNumber = 0;
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Console.WriteLine("Вводите числа, когда закончите ввидете в строку 'конец'");
                maxNumber = Task3_3Avanced();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                Console.WriteLine("Введите 4 числа");
                int a = int.TryParse(Console.ReadLine(), out int resultA) ? resultA : 0;
                int b = int.TryParse(Console.ReadLine(), out int resultB) ? resultB : 0;
                int c = int.TryParse(Console.ReadLine(), out int resultC) ? resultC : 0;
                int d = int.TryParse(Console.ReadLine(), out int resultD) ? resultD : 0;

                if (a > b && a > c && a > d)
                {
                    maxNumber = a;
                }
                else if (b > c && b > d)
                {
                    maxNumber = b;
                }
                else if (c > d)
                {
                    maxNumber = c;
                }
                else
                {
                    maxNumber = d;
                }
            }
            Console.WriteLine($"Максимальное число {maxNumber}");
            Console.ReadKey();
        }

        static int Task3_3Avanced()
        {
            int maxNumber = int.MinValue;
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "конец")
                    break;

                if (int.TryParse(input, out int currentNumber))
                {
                    if (currentNumber > maxNumber)
                    {
                        maxNumber = currentNumber;
                    }
                }
            }
            return maxNumber;
        }

    }
}
