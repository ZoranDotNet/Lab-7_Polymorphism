namespace Lab_7_Polymorphism.Classes
{
    internal class Ellipse : Geometry
    {
        public double A { get; set; }
        public double B { get; set; }

        public Ellipse()
        {
            A = 5;
            B = 3;
        }

        public override double Area(double a, double b)
        {
            double area = a * b * Math.PI;
            return Math.Round(area, 2);
        }



    }
}
