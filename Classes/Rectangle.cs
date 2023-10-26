namespace Lab_7_Polymorphism.Classes
{
    class Rectangle : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }

        //Set values in constructor
        public Rectangle()
        {
            Base = 4;
            Height = 8;
        }

        //override method Area
        public override double Area()
        {
            return Base * Height;
        }

        //override method Circumference
        public override double Circumference()
        {
            return 2 * Base + 2 * Height;
        }





    }
}
