namespace Lab_7_Polymorphism.Classes
{
    class Parallelogram : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Parallelogram()
        {
            Base = 9;
            Height = 4;

        }

        public override double Area(double b, double h)
        {
            return base.Area(b, h);
        }

        public override double Circumference(double b, double h)
        {
            return base.Circumference(b, h);
        }
    }
}
