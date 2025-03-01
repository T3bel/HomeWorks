namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            double sum = 0;
        restartPoint:

            if (!int.TryParse(Console.ReadLine(), out int resultNumber))
            {
                Console.WriteLine("Необходимо ввести число, попробуйте ещё раз");
                goto restartPoint;
            }
            for (int i = 1; i <= resultNumber; i++)
            {
                sum += (double)1 / i;
            }
            Console.WriteLine($"Cумма чисел 1 + 1/2 + 1/3 + … + 1/{resultNumber} равен {sum}");
            Console.ReadKey();

        }
    }
}
