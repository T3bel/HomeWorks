namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число простроенных домов");
            var inputValue = Console.ReadLine();
            var inputNumber = Convert.ToInt32(inputValue);

            var strCore = "Мы построили";
            var strValue = "";

            bool exceptionChecker = (int)((inputNumber % 100) / 10) == 1;

            if (exceptionChecker)
            {
                strValue = "домов";
                Console.WriteLine($"{strCore} {inputNumber} {strValue}");
                Console.ReadKey();
                return;
            }

            switch (inputNumber % 10)
            {
                case 1:
                    strValue = "дом";
                    break;
                case 2:
                case 3:
                case 4:
                    strValue = "дома";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    strValue = "домов";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{strCore} {inputNumber} {strValue}");
            Console.ReadKey();

        }
    }
}
