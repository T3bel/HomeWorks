namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш массив: ");
            const int n = 10;
            var random = new Random();
            int[] numArray = new int[n];
            int maxValue = int.MinValue;
            int maxValueIndex = 0;
            int minValue = int.MaxValue;
            int minValueIndex = 0;
            int evenCounter = 0;

            for (int i = 0; i < n; i++)
            {
                numArray[i] = random.Next(0, 51);

                if (numArray[i] > maxValue)
                {
                    maxValue = numArray[i];
                    maxValueIndex = i;
                }
                if (numArray[i] < minValue)
                {
                    minValue = numArray[i];
                    minValueIndex = i;
                }
                Console.Write($"{numArray[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Максимальное число в массиве {maxValue} и его индекс {maxValueIndex}");
            Console.WriteLine($"Минимальное число в массиве {minValue} и его индекс {minValueIndex}");
            Console.ReadKey();
        }
    }
}
