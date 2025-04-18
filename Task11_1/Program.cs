using System.Text;

namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Dog(),
                new Cat() 
            };
            foreach (var anim in animals)
            {
                Console.WriteLine(anim.ShowInfo());
            }
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string Say();
        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Животное: {Name}");
            sb.AppendLine($"Звук: {Say()}");
            return sb.ToString();
        }
    }
    public class Dog : Animal
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
        }
        public Dog()
        {
            _name = "Пёс";
        }

        public override string Say()
        {
            return "Гав!";
        }
    }
    public class Cat : Animal
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
        }
        public Cat()
        {
            _name = "Кот";
        }

        public override string Say()
        {
            return "Мяяяяу";
        }
    }
}