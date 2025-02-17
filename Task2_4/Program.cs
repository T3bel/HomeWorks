namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы которую хотите округлить");
            double pipeLenght = Convert.ToDouble(Console.ReadLine().Replace('.', ',')); //Добавил от себя реплэйс, чтобы не вылетало с ошибкой при вводе дробной части через точку
            int roundPipeLenght = (int)Math.Ceiling(pipeLenght);
            Console.WriteLine($"Округленная длина трубы {roundPipeLenght}м");
        }
    }
}
