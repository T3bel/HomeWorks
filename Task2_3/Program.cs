namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4-х значное число");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = n / 1000;
            int b = (n / 100) % 10;
            int c = (n/10) % 10;
            int d = n % 10;
            int n2 = a*1000 + d*100 + c*10 + b;

            Console.WriteLine($"В числе поменялись местами 2-я и 4-я цифра: {n2}");
            Console.ReadKey();
        }
    }
}
