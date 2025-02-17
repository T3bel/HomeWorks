namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол в градусах");
            int degree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите минуты");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите секунды");
            int sec = Convert.ToInt32(Console.ReadLine());

            var sumDegree = (degree + min / 60d + sec / 3600d);
            var result = sumDegree * Math.PI / 180d;

            Console.WriteLine($"Угол в радианах равен: {result}");
        }
    }
}
