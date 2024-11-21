namespace ConsoleApp1._4_dars
{
    internal abstract class Shape
    {   
        public string Color { get; set; }
        public abstract double Areaa();
        public string GetColor()
        {
            return Color;
        }
    }
    class Circle : Shape
    {
        public double Radius {  get; set; }
        public override double Areaa()
        {
            return 3.14 * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double Areaa()
        {
            {
                return Length * Width;
            }
        }
    }
}

