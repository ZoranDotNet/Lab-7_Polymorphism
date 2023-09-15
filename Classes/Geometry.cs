namespace Lab_7_Polymorphism.Classes
{
    class Geometry
    {



        public virtual double Area(double b, double h)
        {
            return b * h;
        }

        public virtual double Circumference(double b, double h)
        {
            return 2 * b + 2 * h;
        }

    }
}
