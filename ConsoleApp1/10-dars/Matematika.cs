namespace ConsoleApp1._10_dars
{
    internal class Matematika
    {
        public delegate void MatematikOPerator(double a, double b);
        public double natija;
        public void Qoshish(double a, double b)
        {
            natija = a + b;
            Console.WriteLine($"Ikki sonning yig'indisi: {a} + {b} = {natija}");
        }
        public void Ayirish(double a, double b)
        {
            if (a > b)
            {
                Console.WriteLine($"Ikki sonning Ayirmasi: {a} - {b} = {natija}");
            }
            else
            {
                Console.WriteLine($"Ikki sonning Ayirmas: {b} - {a} = {natija}");
            }
        }
        public void Bolish(double a, double b)
        {
            if (a > b)
            {
                natija = a / b;
                Console.WriteLine($"Ikki sonning Bo'linmasi: {a} / {b} = {natija}");
            }
            else
            {
                natija = b / a;
                Console.WriteLine($"Ikki sonning Bo'linmasi: {b} / {a} = {natija}");
            }
        }
        public void Kopaytirish(double a, double b)
        {
            natija = a * b;
            Console.WriteLine($"Ikki sonning KO'paytmasi: {a} * {b} = {natija}");
        }
    }
}
