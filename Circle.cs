using System;
namespace FormsApp4
{
    public class Circle : Shape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
