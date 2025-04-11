namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int averageNumber = 0;
            int a = int.TryParse(Console.ReadLine(), out int resultA) ? resultA : 0;
            int b = int.TryParse(Console.ReadLine(), out int resultB) ? resultB : 0;
            int c = int.TryParse(Console.ReadLine(), out int resultC) ? resultC : 0;

            if ((a >= b && a <= c) || (a <= b && a >= c))
            {
                averageNumber = a;
            }
            else if (b < c && b > a || (b > c && b < a))
            {
                averageNumber = b;
            }
            else
            {
                averageNumber = c;
            }

            Console.WriteLine($"Среднее число {averageNumber}");
            Console.ReadKey();
        }
    }
}
