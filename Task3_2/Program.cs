namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int maxNumber = 0;
            int a = int.TryParse(Console.ReadLine(), out int resultA) ? resultA : 0;
            int b = int.TryParse(Console.ReadLine(), out int resultB) ? resultB : 0;
            int c = int.TryParse(Console.ReadLine(), out int resultC) ? resultC : 0;

            if (a > b && a > c)
            {
                maxNumber = a;
            }
            else if (b > c)
            {
                maxNumber = b;
            }
            else 
            {
                maxNumber = c;
            }

            Console.WriteLine($"Максимальное число {maxNumber}");
            Console.ReadKey();
        }
    }
}
