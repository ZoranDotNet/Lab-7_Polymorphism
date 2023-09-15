namespace Lab_7_Polymorphism.Classes
{
    class Square : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }


        public Square()
        {
            Base = 8;
            Height = 8;
        }

        public override double Area(double b, double h)
        {
            return base.Area(b, h);
        }

        public override double Circumference(double b, double h)
        {
            return base.Area(b, h);
        }
    }
}
