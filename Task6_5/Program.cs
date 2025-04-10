using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона для проверки (формат: +7(123)456-78-90):");
            string phoneNumber = Console.ReadLine();
            string pattern = @"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$";
            var checkPhoneNumberOutput = Regex.IsMatch(phoneNumber, pattern) ? "Номер телефона корректен" : "Номер телефона некорректен";

            Console.WriteLine(checkPhoneNumberOutput);
            Console.ReadKey();
        }
    }
}
