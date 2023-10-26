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
