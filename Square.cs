namespace FormsApp4
{
    public class Square : Shape
    {
        public double A { get; set; }

        public Square(double a)
        {
            A = a;
        }

        public double GetArea()
        {
            return A * A;
        }
    }
}
