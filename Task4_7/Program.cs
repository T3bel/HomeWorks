namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки");
            int valueNumber = 0;
        restartPoint:
            var valueForAnswer = Console.ReadLine();

            if (!int.TryParse(valueForAnswer, out int resultNumber))
            {
                Console.WriteLine("Необходимо ввести число, попробуйте ещё раз");
                goto restartPoint;
            }

            while (resultNumber > 0)
            {
                resultNumber /= 10;
                valueNumber++;
            }
            Console.WriteLine($"Количество цифр в числе {valueForAnswer} равно {valueNumber}");
            Console.ReadKey();
        }
    }
}
