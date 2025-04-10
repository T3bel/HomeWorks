namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите ваш возраст: ");
                try
                {
                    var age = int.TryParse(Console.ReadLine(),out int intAge)? intAge : throw new FormatException("Введите возраст с помощью цифр");
                    if (age < 0) throw new ArgumentException("Возраст не может быть отрицательным");
                    if (age > 150) throw new ArgumentException("Обычно люди столько не живут(");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Вы молодец!");
            Console.ReadKey();

        }
    }
}
