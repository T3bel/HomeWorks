using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите стороны первого треугольника:");

                    Console.Write("a: ");
                    var a1 = int.Parse(Console.ReadLine());
                    Console.Write("b: ");
                    var b1 = int.Parse(Console.ReadLine());

                    Console.Write("c: ");
                    var c1 = int.Parse(Console.ReadLine());

                    Console.Write("Введите имя треугольника: ");
                    var firstTriangle = new Triangle(a1, b1, c1, Console.ReadLine());
                    Console.WriteLine(firstTriangle.SquareString());
                    Console.WriteLine();
                    
                    Console.WriteLine("Введите стороны второго треугольника:");

                    Console.Write("a: ");
                    var a2 = int.Parse(Console.ReadLine());

                    Console.Write("b: ");
                    var b2 = int.Parse(Console.ReadLine());

                    Console.Write("c: ");
                    var c2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите имя треугольника: ");
                    var secondTriangle = new Triangle(a2, b2, c2, Console.ReadLine());
                    Console.WriteLine(secondTriangle.SquareString());
                    Console.WriteLine();

                    Console.WriteLine(ComparsionTwoTriangle(firstTriangle, secondTriangle));
                    break;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Вы ввели некорректную длину стороны! Попробуйте сначала!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.ReadKey();

        }
        static public string ComparsionTwoTriangle(Triangle first, Triangle second)
        {
            if (first.Square() > second.Square()) return $"Треугольник {first.Name} больше чем треугольник {second.Name}";
            else if (first.Square() < second.Square()) return $"Треугольник {second.Name} больше чем треугольник {first.Name}";
            else if (first.Square() == second.Square()) return $"Треугольники {first.Name} и {second.Name} равны!";
            else return null;
        }
    }
    class Triangle
    {
        public string Name { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public Triangle(int a, int b, int c, string name)
        {
            A = a;
            B = b;
            C = c;
            Name = name;
            IsTriangleValid(a, b, c);
        }
        public double Square()
        {
            if (A == 0 || B == 0 || C == 0)
                return 0;

                double halfPerimeter = (A + B + C) / 2d;
            double triangleSquare = Math.Sqrt(halfPerimeter * (halfPerimeter - A)
                * (halfPerimeter - B) * (halfPerimeter - C));

            return triangleSquare;
        }
        public string SquareString()
        {
            return $"Площадь треугольника {Name} равна: {string.Format("{0:N2}", Square())}";
        }
        private void IsTriangleValid(int a, int b, int c)
        {
            if ((a + b < c || a + c < b || b + c < a))
                throw new ArgumentException("Из введенных сторон невозможно построить треугольник! Попробуйте сначала!");
        }
    }
}
