namespace ConsoleApp1._5_dars
{
    struct Coordinatee
    {
        public int X { get; set; }
        public int Y { get; set; }
        
    }
    struct Rectangle : Ifigure
    {
        public double Eni { get; set; }
        public double Boyi { get; set; }
        public void Figure()
        {
            Console.WriteLine($"Shaklning yuzasi: {Eni * Boyi}");
        }
    }
}
