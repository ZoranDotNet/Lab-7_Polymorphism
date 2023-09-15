using Lab_7_Polymorphism.Classes;

namespace Lab_7_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new();
            Square f1 = new();
            Circle c1 = new();
            Parallelogram p1 = new();
            Ellipse e1 = new();


            Console.WriteLine("Rectangle area is: " + r1.Area(8, 4));
            Console.WriteLine("Rectangle circumference is: " + r1.Circumference(8, 4));
            Console.WriteLine();
            Console.WriteLine("Square area is: " + f1.Area(8, 8));
            Console.WriteLine("Square circumference is: " + f1.Circumference(8, 8));
            Console.WriteLine();
            Console.WriteLine("Circle area is: " + c1.Area(5, 0));
            Console.WriteLine("Circle circumference is: " + c1.Circumference(0, 10));
            Console.WriteLine();
            Console.WriteLine("Parallelogram area is: " + p1.Area(9, 4));
            Console.WriteLine("Parallelogram circumference is: " + p1.Circumference(9, 4));
            Console.WriteLine();
            Console.WriteLine("Ellipse area is: " + e1.Area(5, 3));
            Console.WriteLine("Ellipse circumference is: complicated :)");



        }
    }
}