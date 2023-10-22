namespace Lab_7_Polymorphism.Classes
{
    internal class Ellipse : Geometry
    {
        public double ASemiMajoraxis { get; set; }
        public double BSemiMinorAxis { get; set; }

        public Ellipse()
        {
            ASemiMajoraxis = 5;
            BSemiMinorAxis = 3;
        }

        public override double Area(double ASemiMajoraxis, double BSemiMinorAxis)
        {
            double area = ASemiMajoraxis * BSemiMinorAxis * Math.PI;
            return Math.Round(area, 2);
        }
        // Formula for circumference P = 2⋅π⋅√½⋅(a2+b2)
        public override double Circumference(double ASemiMajoraxis, double BSemiMinorAxis)
        {
            double output = 2 * Math.PI * Math.Sqrt(0.5 * (Math.Pow(ASemiMajoraxis, 2) + Math.Pow(BSemiMinorAxis, 2)));

            return Math.Round(output, 2);
        }
    }
}
