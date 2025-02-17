using System.Reflection.Metadata.Ecma335;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину в дюймах");
            const double inch = 2.54;
            double lenght = Convert.ToDouble(Console.ReadLine()) * inch;

            int a = (int)(lenght / 100 % 100);
            int b = (int)((lenght - a * 100));
            double c = Math.Round((lenght - a * 100 - b) * 10, 1);

            Console.WriteLine($"Длина в метрах {a}");
            Console.WriteLine($"Длина в сантиметрах {b}");
            Console.WriteLine($"Длина в милиметрах {c}");
        }
    }
}
