namespace Task8_1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Калькулятор");
                    Console.WriteLine("-----------");

                    Console.Write("Введите первое целое число: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Введите второе целое число: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nВыберите операцию:");
                    Console.WriteLine("1 - Сложение");
                    Console.WriteLine("2 - Вычитание");
                    Console.WriteLine("3 - Умножение");
                    Console.WriteLine("4 - Деление");
                    Console.Write("Ваш выбор (1-4): ");

                    int operation = int.Parse(Console.ReadLine());

                    double result = CalculateOperation(num1, num2, operation);

                    Console.WriteLine($"\nРезультат: {result}");

                    Console.WriteLine("\nНажмите любую клавишу для выхода...");
                    Console.ReadKey();
                    break;
                }
                catch (FormatException)
                {
                    HandleError("Ошибка: введено не число!");
                }
                catch (DivideByZeroException)
                {
                    HandleError("Ошибка: деление на ноль невозможно!");
                }
                catch (InvalidOperationException ex)
                {
                    HandleError(ex.Message);
                }
                catch (Exception ex)
                {
                    HandleError($"Непредвиденная ошибка: {ex.Message}");
                }
            }
        }

        static double CalculateOperation(int num1, int num2, int operation)
        {
            return operation switch //Увидел про свитч-выражение в тиктоке)
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2,
                4 => num2 == 0
                    ? throw new DivideByZeroException()
                    : (double)num1 / num2,
                _ => throw new InvalidOperationException("Неверный код операции!")
            };
        }

        static void HandleError(string errorMessage)
        {
            Console.WriteLine($"\n{errorMessage}");
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
