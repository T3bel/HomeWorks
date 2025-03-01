using System;
namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите число от 20 до 60 включительно");
            int a = 0;
            string[] naputstviya =
                { "Попробуй ещё раз!",
                "Сегодня не твой день",
                "Ну давай, это же легко!",
                "Из-за тебя я теряю веру в человечество",
                "Бип-бип, запускаю алгоритм восстания машин!",
                $"{Environment.UserName}, хватит шутить со мной!" };

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out a) && a >= 20 && a <= 60) break;

                string naputstvie = naputstviya[random.Next(naputstviya.Length)];
                Console.WriteLine(naputstvie);
            }
            Console.WriteLine("Ну наконец-то!");
            Console.ReadKey();
        }
    }
}
