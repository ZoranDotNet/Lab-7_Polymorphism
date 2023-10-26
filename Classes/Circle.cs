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

        public override double Area()
        {
            return Math.Round(Math.Pow(Radius, 2) * Math.PI);
        }

        public override double Circumference()
        {
            return Math.Round(Math.PI * Diameter, 2);
        }


    }
}
