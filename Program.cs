using System.Drawing;

namespace Assignment_2._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a shape:");
            Console.WriteLine("a) circle");
            Console.WriteLine("b) square");
            String? input = Console.ReadLine();

            Shape? shape = null;
            switch (input)
            {
                case "a":
                    Console.WriteLine("Please provide radius:");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shape = new Circle() { Radius = radius };
                    break;
                case "b":
                    Console.WriteLine("Please provide side:");
                    double side = Convert.ToDouble(Console.ReadLine());
                    shape = new Square() { Side = side };
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
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
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