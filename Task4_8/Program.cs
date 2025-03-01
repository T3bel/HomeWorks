namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для отзеркаливания");
            int valueForAnswer = 0;
        restartPoint:

            if (!int.TryParse(Console.ReadLine(), out int resultNumber))
            {
                Console.WriteLine("Необходимо ввести число, попробуйте ещё раз");
                goto restartPoint;
            }

            while (resultNumber > 0)
            {
                int lastNumber = resultNumber % 10;
                valueForAnswer = valueForAnswer * 10 + lastNumber;
                resultNumber /= 10;
            }

            Console.WriteLine($"Отзеркаленное число {valueForAnswer}");
            Console.ReadKey();
        }
    }
}
