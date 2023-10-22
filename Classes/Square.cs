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

        public override double Area(double baze, double height)
        {
            return baze * height;
        }

        public override double Circumference(double baze, double height)
        {
            return baze * 2 + height * 2;
        }
    }
}
