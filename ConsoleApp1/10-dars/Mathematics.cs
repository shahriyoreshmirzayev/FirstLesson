namespace ConsoleApp1._10_dars
{
    internal class Mathematics
    {
        public delegate void MathOperation(double a, double b);
        public double result;
        public void Qosish(double a, double b)
        {
            result = a + b;
            Console.WriteLine($"Yig'indi: {a} + {b} = {result}");
        }
        public void Ayirma(double a, double b)
        {
            result = a - b;
            Console.WriteLine($"Ayirma: {a} - {b} = {result}");
        }
        public void Bolinma(double a, double b)
        {
            result = a / b;
            Console.WriteLine($"Bo'linma: {a} / {b} = {result}");
        }
        public void Kopaytma(double a, double b)
        {
            result = a * b;
            Console.WriteLine($"Ko'paytma: {a} * {b} = {result}");
        }
    }
}
