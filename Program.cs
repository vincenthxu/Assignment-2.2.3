using System.Drawing;

namespace Assignment_2._2._3
{
    internal class Program
    {
        static Dictionary<string, string> _inputToShape = new()
        {
            { "a", "circle" },
            { "b", "square" },
        };
        static Dictionary<string, string> _shapeToVariable = new()
        {
            { "circle", "radius" },
            { "square", "side" },
        };
        static double GetUserValue(string input)
        {
            Console.WriteLine($"Please provide {_shapeToVariable[_inputToShape[input]]}:");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a shape:");

            foreach (var (key, value) in _inputToShape)
            {
                Console.WriteLine($"{key}) {value}");
            }

            String? input = Console.ReadLine();
            Shape? shape = null;

            switch (input)
            {
                case "a":
                    shape = new Circle() { Radius = GetUserValue(input) };
                    break;
                case "b":
                    shape = new Square() { Side = GetUserValue(input) };
                    break;
                default:
                    Console.WriteLine("Error: invalid option!");
                    break;
            }
            if (shape != null)
                Console.WriteLine($"Area is: {shape.CalculateArea()}");
        }
    }
    public abstract class Shape
    {
        public int ID { get; set; }
        public String? Name { get; set; }
        public Color Color { get; set; }
        public int Sides { get; }
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public double Diameter
        {
            get
            {
                return Radius * 2;
            }
        }
        public double Circumference
        {
            get
            {
                return Math.PI * 2 * Radius;
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Square : Shape
    {
        public double Side { get; set; }
        public double Diagonal
        {
            get
            {
                return Math.Sqrt(2) * Side;
            }
        }
        public double Perimeter
        {
            get
            {
                return 4 * Side;
            }
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
}