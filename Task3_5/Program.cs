namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = Convert.ToInt32(Console.ReadLine());

            var outputTextFor5Task = inputNumber % 10 == 0 ? "Число оканчивается на 0" : "Число не оканчивается на 0";
            var outputTextFor6Task = inputNumber % 2 == 0 ? "Число четное" : "Число нечетное";
            var outputTextFor7Task = inputNumber > 9 && inputNumber < 100 ? "Число двухзначное" : "Число не двухзначное";
            var outputTextFor8Task = inputNumber >= -10 && inputNumber <= 10 ? "Число в диапазоне от -10 до 10" : "Число НЕ в диапазоне от -10 до 10";
            var outputTextFor9Task = (inputNumber > int.MinValue && inputNumber <= -10 || inputNumber < int.MaxValue && inputNumber >= 10) ? "Число в диапазоне  (-∞; -10] U [10; +∞)" : "Число НЕ в диапазоне  (-∞; -10] Ս [10; +∞)";

            Console.WriteLine($"{outputTextFor5Task}\n{outputTextFor6Task}\n{outputTextFor7Task}\n{outputTextFor8Task}\n{outputTextFor9Task}");
        }
    }
}
