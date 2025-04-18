using System.Diagnostics;

namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки");
            int checker = 1;
            int degree = 0;
        restartPoint:

            if (!int.TryParse(Console.ReadLine(), out int resultNumber))
            {
                Console.WriteLine("Необходимо ввести число, попробуйте ещё раз");
                goto restartPoint;
            }

            while (resultNumber > checker)
            {
                checker *= 2;
                degree++;
            }

            if (resultNumber == checker)
            {
                Console.WriteLine($"Число {resultNumber} равняется 2-м в степени {degree}");
            }
            else
            {
                Console.WriteLine("Число не равняется 2-м в какой-либо степени");
            }
            Console.ReadKey();
        }
    }
}
