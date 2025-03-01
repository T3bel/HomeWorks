namespace Task4_3and4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 1;
        restartPoint:
            Console.WriteLine("Введите число a больше нуля");
            var a = int.TryParse(Console.ReadLine(), out int resultNumberA) && resultNumberA>0 ? resultNumberA : 0;
            Console.WriteLine("Введите степень b");
            var b = int.TryParse(Console.ReadLine(), out int resultNumberB)? resultNumberB : 0;
            if (a== 0 || b==0)
            {
                Console.WriteLine("Необходимо ввести число больше нуля, попробуйте ещё раз");
                goto restartPoint;
            }

            for (int i = 1; i <= Math.Abs(resultNumberB); i++)
            {
                if (b > 0)
                {
                    result *= resultNumberA;

                }
                else
                {
                    result *= (double) 1/resultNumberA;
                }

            }
            
            Console.WriteLine($"Число {resultNumberA} в степени {resultNumberB} равняется {result}");
            Console.ReadKey();
        }
    }
}
