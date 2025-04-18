using System.Reflection.Metadata.Ecma335;

namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables =
            {
                new Bird(150),
                new Airplane(8000,150)
            };
            foreach (var flyable in flyables)
            {
                Console.WriteLine(flyable.Fly());
            }
        }
    }
    interface IFlyable
    {
        string Fly();
        int MaxAltitude { get; }
    }

    class Bird : IFlyable
    {
        public virtual string Name => "Птица"; //Сделал виртуал, чтобы можно было унаследовать класс и создать конкретную птицу, например голубь
        public Bird(int maxAltitude)
        {
            _maxAltitude = maxAltitude;
        }
        private int _maxAltitude;
        public int MaxAltitude => _maxAltitude;

        public string Fly()
        {
            return $"Я {Name}. Лечу на высоте {MaxAltitude} метров";
        }
    }


    class Airplane : IFlyable
    {
        public virtual string Name => "Самолёт";

        private int _maxAltitude;
        public int MaxAltitude => _maxAltitude;
        public int CountPassengers { get; set; }
        public Airplane(int maxAltitude, int countPassengers)
        {
            _maxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }

        public string Fly()
        {
            return $"Я {Name}. Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров";
        }
    }

}
