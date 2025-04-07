namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа через запятую для поиска максимального из них");
            int[] numbers = Console.ReadLine().Split(',').Select(x =>
            {
                if (int.TryParse(x, out int xInt)) return xInt;
                return 0;
            }
            ).ToArray<int>();
            int maxNum = FindMax(numbers);
            Console.WriteLine($"Максимальное число: {maxNum}");
            Console.ReadKey();
        }
        static int FindMax(params int[] nums)
        {
            int maxNum = nums.OrderByDescending(x => x).FirstOrDefault();
            return maxNum;
        }

    }
}
