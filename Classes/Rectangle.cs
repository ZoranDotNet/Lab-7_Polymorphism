namespace Lab_7_Polymorphism.Classes
{
    class Rectangle : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Base = 4;
            Height = 8;
        }

        public override double Area(double b, double h)
        {
            return b * h;
        }

        public override double Circumference(double b, double h)
        {
            return 2 * b + 2 * h;
        }

    }
}
