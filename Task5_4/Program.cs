namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш массив");
            const int n = 10;
            var random = new Random();
            int[] numArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                numArray[i] = random.Next(0, 11);
                Console.Write($"{numArray[i]} ");
            }

            for (int i = 0, j = numArray.Length - 1; i < numArray.Length / 2; i++, j--)
            {
                int t = numArray[i];
                numArray[i] = numArray[j];
                numArray[j] = t;

            }
            Console.WriteLine("Отзеркаленный массив");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write($"{numArray[i]} ");
            }

        }
    }
}
