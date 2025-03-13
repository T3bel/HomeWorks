namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш массив: ");
            const int n = 10;
            int[] numArray = new int[n];
            int[] numLessThanZero = new int[0];
            int[] numMoreThanZero = new int[0];
            int zeroCounter = 0;
            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                numArray[i] = random.Next(-20,21);

                if (numArray[i] > 0)
                {
                    Array.Resize(ref numMoreThanZero, numMoreThanZero.Length + 1);
                    numMoreThanZero[numMoreThanZero.Length - 1] = numArray[i];
                }
                else if (numArray[i] < 0)
                {
                    Array.Resize(ref numLessThanZero, numLessThanZero.Length + 1);
                    numLessThanZero[numLessThanZero.Length - 1] = numArray[i];
                }
                else
                {
                    zeroCounter++;
                }
                Console.Write($"{numArray[i]} ");

            }

            Console.WriteLine("\nЧисла больше нуля: ");
            foreach (var num in numMoreThanZero)
            {
                Console.Write($"{num} ");
            }
            Console.Write($"Всего их {numMoreThanZero.Length}");

            Console.WriteLine("\nЧисла меньше нуля: ");
            foreach (var num in numLessThanZero)
            {
                Console.Write($"{num} ");
            }
            Console.Write($"Всего их {numLessThanZero.Length}");

            Console.WriteLine($"\nКоличество нулей: {zeroCounter}");
            Console.ReadKey();


        }
    }
}
