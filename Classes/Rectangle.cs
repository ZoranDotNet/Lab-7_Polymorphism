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

        public override double Area(double baze, double height)
        {
            return baze * height;
        }

        public override double Circumference(double baze, double height)
        {
            return 2 * baze + 2 * height;
        }

    }
}
