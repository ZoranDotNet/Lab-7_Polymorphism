using Lab_7_Polymorphism.Classes;

namespace Lab_7_Polymorphism
{// Zoran Matovic NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate objects
            Rectangle r1 = new Rectangle();
            Square s1 = new Square();
            Circle c1 = new Circle();
            Parallelogram p1 = new Parallelogram();
            Ellipse e1 = new Ellipse();



            //Call our methods and print results
            Console.WriteLine($"Area of rectangle is: {r1.Area(r1.Base, r1.Height)} cm²");
            Console.WriteLine($"Circumference of rectangle is: {r1.Circumference(r1.Base, r1.Height)} cm");
            Console.WriteLine();
            Console.WriteLine($"Area of square is: {s1.Area(s1.Base, s1.Height)} cm²");
            Console.WriteLine($"Circumference of square is: {s1.Circumference(s1.Base, s1.Height)} cm");
            Console.WriteLine();
            Console.WriteLine($"Area of circle is: {c1.Area(c1.Radius, c1.Diameter)} cm²");
            Console.WriteLine($"Circumference of circle is: {c1.Circumference(c1.Radius, c1.Diameter)} cm");
            Console.WriteLine();
            Console.WriteLine($"Area of parallelogram is: {p1.Area(p1.Base, p1.Height)} cm²");
            Console.WriteLine($"Circumference of parallelogram is: {p1.Circumference(p1.Base, p1.Height)} cm");
            Console.WriteLine();
            Console.WriteLine($"Area of ellipse is: {e1.Area(e1.ASemiMajoraxis, e1.BSemiMinorAxis)} cm²");
            Console.WriteLine($"Circumference of ellipse is: {e1.Circumference(e1.ASemiMajoraxis, e1.BSemiMinorAxis)} cm");



        }
    }
}