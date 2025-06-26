namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = new List<string>();

            players.Add("Иванов");
            players.Add("Петров");
            players.Add("Сидоров");

            players.Insert(1, "Козлов");

            var hasPetrov = players.Contains("Петров");
            Console.WriteLine($"Есть ли игрок Петров в команде? {hasPetrov}");

            players.Remove("Сидоров");

            var indexKozlov = players.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока Козлов : {indexKozlov}");

            players.Sort();


            Console.WriteLine("Состав команды:");

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {players[i]}");
            }

            var listIsEmpty = players.Count == 0;
            Console.WriteLine($"Команда пуста? {listIsEmpty}");

            players.Clear();

            Console.WriteLine($"Количество игроков после очистки: {players.Count}");
        }
    }
}