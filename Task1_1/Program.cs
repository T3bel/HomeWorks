namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа для их сложения");

            if (!int.TryParse(Console.ReadLine(), out var a) | !int.TryParse(Console.ReadLine(), out var b))
            {
                var warningText = a == 0 ? $"первом" : $"втором";
                Console.WriteLine($"Ошибка в {warningText} числе! Введите целое число");
                return;
            }

            Console.WriteLine($"Сумма чисел равна {a + b}");
            Console.ReadKey();

        }

    }
}
