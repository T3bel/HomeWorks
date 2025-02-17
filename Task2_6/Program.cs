namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;  

            Console.WriteLine($"a={a} , b={b}");
        }
    }
}
