namespace Task17_1
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Программа запущена");

            Console.WriteLine("\nСпособ 1: Использование задач продолжения");
            Task<int[]> generateTask = Task.Run(() => GenerateArrayWithDelay(10));

            var calculateTask = generateTask.ContinueWith(t =>
            {
                int[] array = t.Result;
                return CalculateAverageWithDelay(array);
            });

            Console.WriteLine($"Среднее значение (продолжение): {calculateTask.Result}");

            Console.WriteLine("\nСпособ 2: Использование async/await");
            try
            {
                int[] array = await GenerateArrayWithDelayAsync(10);
                double average = await CalculateAverageWithDelayAsync(array);
                Console.WriteLine($"Среднее значение (async/await): {average}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }

        static int[] GenerateArrayWithDelay(int size)
        {
            Console.WriteLine("Начало генерации массива...");
            Thread.Sleep(2000); 

            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("\nМассив сгенерирован!");
            return array;
        }

        static double CalculateAverageWithDelay(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Массив не может быть пустым");

            Console.WriteLine("Начало вычисления среднего...");
            Thread.Sleep(1500);

            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }

        static async Task<int[]> GenerateArrayWithDelayAsync(int size)
        {
            return await Task.Run(() => GenerateArrayWithDelay(size));
        }

        static async Task<double> CalculateAverageWithDelayAsync(int[] numbers)
        {
            return await Task.Run(() => CalculateAverageWithDelay(numbers));
        }
    }
}
