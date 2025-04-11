namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            var edgeLenght = double.TryParse(Console.ReadLine().Replace(',', '.'), out double edge) ? edge : 0;
            double volume = 0d;
            double surfaceArea = 0d;
            CalcCube(edgeLenght, out volume, out surfaceArea);
            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");
            Console.ReadKey();
        }

        static void CalcCube(double edgeLenght, out double volume, out double surfaceArea)
        {
            surfaceArea = Math.Pow(edgeLenght, 2) * 6;
            volume = Math.Pow(edgeLenght, 3);
        }
    }
}
