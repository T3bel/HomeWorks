namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры территории");
            var territoryA = int.TryParse(Console.ReadLine(), out int resultTerrytoryA) ? resultTerrytoryA : 0;
            var territoryB = int.TryParse(Console.ReadLine(), out int resultTerrytoryB) ? resultTerrytoryB : 0;

            Console.WriteLine("Введите размеры первого здания");
            int firstHouseA = int.TryParse(Console.ReadLine(), out int resultFirstHouseA) ? resultFirstHouseA : 0;
            int firstHouseB = int.TryParse(Console.ReadLine(), out int resultFirstHouseB) ? resultFirstHouseB : 0;

            Console.WriteLine("Введите размеры второго здания");
            int secondHouseA = int.TryParse(Console.ReadLine(), out int resultSecondHouseA) ? resultSecondHouseA : 0;
            int secondHouseB = int.TryParse(Console.ReadLine(), out int resultSecondHouseB) ? resultSecondHouseB : 0;

            if (firstHouseA + secondHouseA <= resultTerrytoryA || firstHouseB + secondHouseB <= resultTerrytoryB)
            {
                Console.WriteLine("Дома возможно разместить в данном участке");
            } 
            else if ((firstHouseA + secondHouseB <= resultTerrytoryA && Math.Max(firstHouseB, secondHouseA) <= resultTerrytoryB)
                || (firstHouseB + secondHouseA <= resultTerrytoryB && Math.Max(firstHouseA,secondHouseB) <= resultTerrytoryA))
            {
                Console.WriteLine("Дома возможно разместить в данном участке, если один из домов развернуть на 90 градусов");
            }
            else
            {
                Console.WriteLine("Дома невозможно разместить в данном участке");
            }
            Console.ReadKey();
        }
    }
}
