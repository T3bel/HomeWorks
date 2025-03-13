namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] numArray = new int[n];
            Random random = new Random();
            Console.WriteLine("Ваш массив:");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = random.Next(-50, 51);
                Console.Write($"{numArray[i]} ");
            }

            for (int i = 0; i < n/2; i++)
            {
                for (int j = i + 1; j < n/2; j++)
                {
                    if (numArray[i] > numArray[j])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;
                    }
                }
            }

            for (int i = n/2; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (numArray[i] < numArray[j])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив:");
            foreach (int value in numArray)
            {
                Console.Write($"{value} ");
            }
            Console.ReadKey();
        }                
    }
}
