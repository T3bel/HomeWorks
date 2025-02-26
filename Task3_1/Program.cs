namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            inputValuePoint:
            if (!int.TryParse(Console.ReadLine(),out int a) | 
                !int.TryParse(Console.ReadLine(), out int b))
            {

                Console.WriteLine("Это не число, попробуйте ещё раз");
                goto inputValuePoint;
            }


            if (a > b) Console.WriteLine($"Число {a} больше чем {b}");
            else if (a < b) Console.WriteLine($"Число {a} меньше чем {b}");
            else  Console.WriteLine($"Число {a} равняется числу {b}");
        }
    }
}
