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

            //add object to list
            List<Geometry> myList = new() { r1, s1, c1, p1, e1 };

            //Loop and call methods
            foreach (Geometry item in myList)
            {
                Console.WriteLine($"{item.GetType().Name} area: {item.Area()}");
                Console.WriteLine($"{item.GetType().Name} circumference: {item.Circumference()}");
                Console.WriteLine();
            }



        }
    }
}