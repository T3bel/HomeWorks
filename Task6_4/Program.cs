using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            name = char.ToUpper((char)name[0]) + name.Substring(1).ToLower();

            Console.WriteLine("Введите ваш возраст:");
            string age = Console.ReadLine();

            if (!int.TryParse(age, out int intAge) | intAge <= 0 | intAge > 100)
            {
                Console.WriteLine("Вы указали некорректный возраст");
                return;
            }

            Console.WriteLine("Введите ваш город:");
            string city = Console.ReadLine();
            city = char.ToUpper((char)city[0]) + city.Substring(1).ToLower();

            StringBuilder userInfo = new StringBuilder();
            userInfo.Append("Имя: ").Append(name).Append(", ");
            userInfo.Append("Возраст: ").Append(age).Append(", ");
            userInfo.Append("Город: ").Append(city);

            Console.WriteLine("\nИнформация о пользователе:");
            Console.WriteLine(userInfo.ToString());
        }
    }
}
