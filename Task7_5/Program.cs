namespace Task7_5
{
    using System;

    internal class Program
    {

        public static void Main()
        {
            Console.WriteLine("Введите первое число:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
            string input2 = Console.ReadLine();

            double double1, double2;
            int int1, int2;

            if ((input1+input2).Contains(',') && double.TryParse(input1, out double1) && double.TryParse(input2, out double2))
            {
                Console.WriteLine("Результат умножения (double): " + Multiply(double1, double2));
            }
            else if (int.TryParse(input1, out int1) && int.TryParse(input2, out int2))
            {
                Console.WriteLine("Результат умножения (int): " + Multiply(int1, int2));
            }
            else
            {
                Console.WriteLine("Ошибка: введены не числовые значения");
                return;
            }
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

    }
}
