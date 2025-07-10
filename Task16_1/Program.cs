namespace Task16_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Computer
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public double ProcessorFrequency { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public int VideoMemory { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Code} {Brand}, {ProcessorType} {ProcessorFrequency}GHz, {Ram}GB RAM, {Hdd}GB HDD, {VideoMemory}GB VRAM, {Price:Р}, {Quantity} шт.";
        }
    }

    class Program
    {
        static void Main()
        {
            List<Computer> computers = GetSampleComputers();

            //Компьютеры с указанным процессором
            string processor = GetUserInput(
                prompt: "Введите тип процессора для поиска (например, 'Intel i5'): ",
                errorMessage: "Компьютера с указанным процессором нет в наличии!",
                validation: input => !string.IsNullOrWhiteSpace(input) && computers.Any(item => item.ProcessorType.Equals(input)));

            var byProcessor = computers
                .Where(c => c.ProcessorType.Equals(processor, StringComparison.OrdinalIgnoreCase))
                .ToList();

            PrintResults($"Компьютеры с процессором {processor}:", byProcessor);

            //Компьютеры с объемом ОЗУ не ниже указанного
            int minRam = GetUserInput<int>(
                prompt: "Введите минимальный объем ОЗУ (GB, от 1 до 128): ",
                errorMessage: "Ошибка: введите целое число от 1 до 128!",
                validation: input => input >= 1 && input <= 128,
                parser: int.TryParse);

            var byRam = computers.Where(c => c.Ram >= minRam).ToList();
            PrintResults($"Компьютеры с ОЗУ не менее {minRam}GB:", byRam);

            // Остальные операции
            PrintSortedByPrice(computers);
            PrintGroupedByProcessor(computers);
            PrintMostAndLeastExpensive(computers);
            CheckStockAvailability(computers);
        }

        /// <summary>
        /// Метод для получения списка компьютеров
        /// </summary>
        /// <returns></returns>
        static List<Computer> GetSampleComputers()
        {
            return new List<Computer>
        {
            new Computer { Code = "A100", Brand = "Dell", ProcessorType = "Intel i5", ProcessorFrequency = 2.5, Ram = 8, Hdd = 512, VideoMemory = 4, Price = 50000, Quantity = 15 },
            new Computer { Code = "B200", Brand = "HP", ProcessorType = "Intel i7", ProcessorFrequency = 3.2, Ram = 16, Hdd = 1024, VideoMemory = 6, Price = 75000, Quantity = 8 },
            new Computer { Code = "C300", Brand = "Lenovo", ProcessorType = "AMD Ryzen 5", ProcessorFrequency = 3.6, Ram = 16, Hdd = 512, VideoMemory = 4, Price = 45000, Quantity = 20 },
            new Computer { Code = "D400", Brand = "Asus", ProcessorType = "Intel i9", ProcessorFrequency = 3.8, Ram = 32, Hdd = 2048, VideoMemory = 8, Price = 120000, Quantity = 5 },
            new Computer { Code = "E500", Brand = "Acer", ProcessorType = "AMD Ryzen 7", ProcessorFrequency = 3.4, Ram = 32, Hdd = 1024, VideoMemory = 6, Price = 68000, Quantity = 12 },
            new Computer { Code = "F600", Brand = "MSI", ProcessorType = "Intel i5", ProcessorFrequency = 2.9, Ram = 8, Hdd = 512, VideoMemory = 2, Price = 42000, Quantity = 35 },
            new Computer { Code = "G700", Brand = "Apple", ProcessorType = "M1", ProcessorFrequency = 3.2, Ram = 16, Hdd = 512, VideoMemory = 8, Price = 95000, Quantity = 10 }
        };
        }

        /// <summary>
        /// Универсальный метод для получения ввода пользователя (строки)
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="errorMessage"></param>
        /// <param name="validation"></param>
        /// <returns></returns>
        static string GetUserInput(string prompt, string errorMessage, Func<string, bool> validation)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (!validation(input))
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!validation(input));

            return input;
        }


        /// <summary>
        /// Универсальный метод для получения ввода пользователя (обобщенный)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="prompt"></param>
        /// <param name="errorMessage"></param>
        /// <param name="validation"></param>
        /// <param name="parser"></param>
        /// <returns></returns>
        static T GetUserInput<T>(string prompt, string errorMessage, Func<T, bool> validation, TryParseHandler<T> parser)
        {
            T value;
            bool validInput;
            do
            {
                Console.Write(prompt);
                validInput = parser(Console.ReadLine(), out value);

                if (!validInput || !validation(value))
                {
                    Console.WriteLine(errorMessage);
                    validInput = false;
                }
            } while (!validInput);

            return value;
        }

        /// <summary>
        /// Метод для вывода результатов поиска
        /// </summary>
        /// <param name="header"></param>
        /// <param name="computers"></param>
        static void PrintResults(string header, List<Computer> computers)
        {
            Console.WriteLine($"\n{header}");
            if (computers.Any())
            {
                computers.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Ничего не найдено.");
            }
        }

        /// <summary>
        /// Метод для вывода списка отсортированного по цене
        /// </summary>
        /// <param name="computers"></param>
        static void PrintSortedByPrice(List<Computer> computers)
        {
            Console.WriteLine("\nСписок компьютеров по возрастанию цены:");
            computers.OrderBy(c => c.Price).ToList().ForEach(Console.WriteLine);
        }

        /// <summary>
        /// Метод для вывода списка сгруппированного по процессору
        /// </summary>
        /// <param name="computers"></param>
        static void PrintGroupedByProcessor(List<Computer> computers)
        {
            Console.WriteLine("\nСписок компьютеров по типу процессора:");
            foreach (var group in computers.GroupBy(c => c.ProcessorType))
            {
                Console.WriteLine($"\nПроцессор: {group.Key}");
                foreach (var computer in group)
                {
                    Console.WriteLine(computer);
                }
            }
        }

        /// <summary>
        /// Метод для вывода самого дорогого и самого бюджетного компьютера
        /// </summary>
        /// <param name="computers"></param>
        static void PrintMostAndLeastExpensive(List<Computer> computers)
        {
            var mostExpensive = computers.OrderByDescending(c => c.Price).First();
            var cheapest = computers.OrderBy(c => c.Price).First();
            Console.WriteLine($"\nСамый дорогой компьютер: {mostExpensive}");
            Console.WriteLine($"Самый бюджетный компьютер: {cheapest}");
        }

        /// <summary>
        /// Метод для проверки наличия компьютеров в количестве ≥ 30
        /// </summary>
        /// <param name="computers"></param>
        static void CheckStockAvailability(List<Computer> computers)
        {
            bool hasStock = computers.Any(c => c.Quantity >= 30);
            Console.WriteLine($"\nЕсть ли компьютеры в количестве ≥ 30 шт.: {hasStock}");

            var stockComputer = computers.FirstOrDefault(c => c.Quantity >= 30);
            if (stockComputer != null)
            {
                Console.WriteLine($"Компьютер в наличии ≥ 30 шт.: {stockComputer}");
            }
        }
    }

    delegate bool TryParseHandler<T>(string input, out T result);

}
