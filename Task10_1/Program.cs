using System.Net;
using System.Text;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building1 = new Building("ул.Пушкина, д. Колотушкина", 1204.5, 1988);
            var multiBuilding1 = new MultiBuilding("Дом как дом", 3658, 2011, 23, true);

            Console.WriteLine(building1.DisplayInfo());
            Console.WriteLine($"Налог: {String.Format("{0:N2}", building1.CalculateTax())} р");
            Console.WriteLine($"Возраст здания: {building1.BuildingAge}\n");

            Console.WriteLine(multiBuilding1.DisplayInfo());
            Console.WriteLine($"Налог: {String.Format("{0:N2}", multiBuilding1.CalculateTax())} р");
            Console.WriteLine($"Возраст здания: {multiBuilding1.BuildingAge}");
            Console.WriteLine($"Средняя площадь на этаж: {multiBuilding1.AreaPerFloor:F2}\n");


            //Upcast
            Building upcastBuilding = multiBuilding1;
            Console.WriteLine("multiBuilding1 После Upcasting'a: \n");
            Console.WriteLine(upcastBuilding.DisplayInfo());

            //Downcast
            if (upcastBuilding is MultiBuilding)
            {
                MultiBuilding downcastBuilding = (MultiBuilding)upcastBuilding;
                Console.WriteLine("upcastBuilding После Downcasting'a: \n");
                Console.WriteLine(downcastBuilding.DisplayInfo());
            }


            try
            {
                var building2 = new Building("ул.Пушкина, д. Колотушкина", 1204.5, 2046);
                Console.WriteLine($"Возраст здания: {building2.BuildingAge}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                var building2 = new Building("ул.Пушкина, д. Колотушкина", 1204.5, -100);
                Console.WriteLine($"Возраст здания: {building2.BuildingAge}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                var multiBuilding2 = new MultiBuilding("Дом как дом", 3658, 2011, -2, true);
                Console.WriteLine($"Средняя площадь на этаж: {multiBuilding2.AreaPerFloor:F2}");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
    
    public class Building
    {
        protected private string _adress;
        protected private double _area;
        protected private int _yearBuild;

        public int BuildingAge
        {
            get
            {
                int currentYear = DateTime.Now.Year;
                if (_yearBuild <= 0 || _yearBuild > currentYear)
                    throw new InvalidOperationException("Некорректный год постройки здания!");

                return currentYear - _yearBuild;
            }
        }
        public Building(string adress, double area, int yearBuild)
        {
            _adress = adress;
            _area = area;
            _yearBuild = yearBuild;

        }
        public virtual double CalculateTax()
        {
            return _area * 1000;
        }
        public virtual string DisplayInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Адрес здания: {_adress}");
            sb.AppendLine($"Площадь здания: {_area}");
            sb.AppendLine($"Год постройки: {_yearBuild}");
            return sb.ToString();
        }


    }
    public sealed class MultiBuilding : Building
    {
        private int _floors;
        private bool _haveElevator;
        public MultiBuilding(string adress, double area, int yearBuild, int floors, bool haveElevator)
            : base(adress, area, yearBuild)
        {
            _floors = floors;
            _haveElevator = haveElevator;
        }
        public double AreaPerFloor
        {
            get
            {
                if (_floors <= 0)
                    throw new InvalidOperationException("Количество этажей должно быть положительным");

                if (_area <= 0)
                    throw new InvalidOperationException("Площадь здания должна быть положительной");

                return _area / _floors;
            }
        }
        public override double CalculateTax()
        {
            double elevatorTax = _haveElevator ? 5000 : 0;
            return base.CalculateTax() * (1 + (_floors - 1) * 0.05) + elevatorTax;
        }
        public override string DisplayInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Адрес здания: {_adress}");
            sb.AppendLine($"Площадь здания: {_area}");
            sb.AppendLine($"Количество этажей: {_floors}");
            sb.AppendLine($"Год подстройки: {_yearBuild}");
            sb.AppendLine($"Наличие лифта: {(_haveElevator ? "Есть" : "Отсутствует")}");
            return sb.ToString();
        }
    }
}
