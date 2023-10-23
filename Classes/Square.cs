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

        public override double Area(double squareBase, double height)
        {
            return squareBase * height;
        }

        public override double Circumference(double squareBase, double height)
        {
            return squareBase * 2 + height * 2;
        }
    }
}
