using System.Globalization;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц  и год в формате mm/yyyy за который хотите создать отчет");
            var date = Console.ReadLine();

            var monthName = MonthConverter(ref date);
            if (monthName == null)
            {
                Console.WriteLine("Ошибка при вводе даты, введите дату в формате mm/yyyy");
                return;
            }


            Console.WriteLine("Введите общую сумму продаж");
            var sum = double.TryParse(Console.ReadLine().Replace('.',','), out double doubleSum);
            var resultSum = string.Format("{0:N2}", doubleSum);


            Console.WriteLine("Введите количество проданных товаров");
            var value = int.TryParse(Console.ReadLine(), out int intValue);
            var resultValue = string.Format("{0:N0}", intValue);

            var avarageCost = (double)doubleSum / intValue;
            var resultAvarageCost = string.Format("{0:N2}", avarageCost);

            string lineSeparator = "--------------------------------\n";

            Console.WriteLine($"{lineSeparator}" +
                $"Отчет о продажах за {monthName} {date}\n" +
                $"{lineSeparator}" +
                $"Общая сумма продаж: {resultSum} р.\n" +
                $"Количество проданных товаров: {resultValue} шт.\n" +
                $"Средняя стоимость товара: {resultAvarageCost} р.\n" +
                $"{lineSeparator}");
            Console.ReadKey();

        }

        static private string MonthConverter(ref string inputString)
        {
            string pattern = @"^(0[1-9]|1[0-2])\/(20\d{2}|19\d{2}|2[1-9]\d{2})$";
            if (!Regex.IsMatch(inputString, pattern)) return null;

            var monthNum = int.Parse(inputString.Split('/')[0]);

            string[] monthNames = { null, "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

            inputString = inputString.Split('/')[1];

            return monthNames[monthNum];
        }
    }
}
