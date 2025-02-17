namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы которую хотите округлить");

            var pipeLenght = Convert.ToDouble(Console.ReadLine().Replace('.',','));
            var roundPipeLenght = Math.Round(pipeLenght * 2) / 2;

            Console.WriteLine($"Округленная длина трубы {roundPipeLenght}м");
        }
    }
}
