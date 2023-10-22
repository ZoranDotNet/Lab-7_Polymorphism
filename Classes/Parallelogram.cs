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

        public override double Area(double baze, double height)
        {
            return baze * height;
        }

        public override double Circumference(double baze, double height)
        {
            return baze * height;
        }
    }
}
