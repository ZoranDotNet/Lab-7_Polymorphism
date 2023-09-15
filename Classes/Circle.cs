namespace Lab_7_Polymorphism.Classes
{
    class Circle : Geometry
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }

        public Circle()
        {
            Radius = 6;
            Diameter = Radius * 2;
        }

        public override double Area(double radius, double d)
        {
            return Math.Round(Math.Pow(radius, 2) * Math.PI, 2);
        }

        public override double Circumference(double r, double d)
        {
            return Math.Round(d * Math.PI, 2);
        }


    }
}
