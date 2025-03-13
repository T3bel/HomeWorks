namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            var random = new Random();
            int[] numArray = new int[n];
            int evenCounter = 0;

            for (int i = 0; i < n; i++)
            {
                numArray[i] = random.Next(0, 101);
                evenCounter += numArray[i] % 2 == 0 ? 1 : 0;
                Console.Write($"{numArray[i]} ");
            }

            string outputText = evenCounter > numArray.Length / 2 ? "Четных чисел больше чем нечетных" : 
                evenCounter == numArray.Length / 2 ? "Количество четных и нечетных чисел равно" : "Нечетных чисел больше чем четных";

            Console.WriteLine($"\n{outputText}");
            Console.ReadKey();

        }
    }
}
