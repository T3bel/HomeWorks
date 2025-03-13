namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] tdArray = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int maxValue = int.MinValue;
                for (int j = 0; j < m; j++)
                {
                    
                    tdArray[i, j] = rnd.Next(0, 11);
                    maxValue = tdArray[i, j] > maxValue ? tdArray[i, j] : maxValue;
                    Console.Write("{0,4}", tdArray[i, j]);
                }
                Console.Write($"  Максимальное значение строки {maxValue}");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
