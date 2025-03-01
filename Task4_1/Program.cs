namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            ulong factorial = 1;
        restartPoint:

            if (!int.TryParse(Console.ReadLine(), out int resultNumber))
            {
                Console.WriteLine("Необходимо ввести число, попробуйте ещё раз");
                goto restartPoint;
            }

            try
            {
                checked
                {
                    for (int i = 1; i <= resultNumber; ++i)
                    {
                        factorial *= (ulong)i;
                    }
                }
            }

            catch (OverflowException)
            {
                Console.WriteLine("Произошло переполнение поддерживаемого диапазона. Пожалуйста, ввидете число поменьше");
                goto restartPoint;
            }

            Console.WriteLine($"Факториал числа {resultNumber} равен {factorial}");
            Console.ReadKey();

        }
    }
}
