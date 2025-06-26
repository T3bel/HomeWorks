namespace Task14_1
{
    public delegate int Transformer(int x);

    public class ArrayTransformer
    {
        public static int[] Transform(int[] array, Transformer transformer)
        {
            if (array == null || transformer == null)
                throw new ArgumentNullException();

            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = transformer(array[i]);
            }
            return result;
        }
    }

    internal class Program
    {
        static void Main()
        {
            int[] numbers = { -2, -1, 0, 1, 2 };

            var doubled = ArrayTransformer.Transform(numbers, x => x * 2);
            Console.WriteLine("Удвоенные числа: " + string.Join(", ", doubled));

            var squared = ArrayTransformer.Transform(numbers, x => x * x);
            Console.WriteLine("Квадраты чисел: " + string.Join(", ", squared));

            var absolute = ArrayTransformer.Transform(numbers, Math.Abs);
            Console.WriteLine("Модули чисел: " + string.Join(", ", absolute));
        }
    }
}
