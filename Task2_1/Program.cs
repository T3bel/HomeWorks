namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int t1 = a;
            int t2 = b;
            a = c;
            b = t1;
            c = t2;
            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}
