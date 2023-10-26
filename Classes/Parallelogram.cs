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

        public override double Area()
        {
            return Base * Height;
        }

        public override double Circumference()
        {
            return Base * 2 + Height * 2;
        }
    }
}
