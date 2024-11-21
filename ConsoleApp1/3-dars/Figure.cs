namespace ConsoleApp1._3_dars
{
    internal class Figure
    {
        public virtual void area()
        {
            Console.WriteLine("Yuzani hisoblash");
        }
        public virtual void perimeter()
        {
            Console.WriteLine("perimetrni hisoblash");
        }
    }
    class Aylana : Figure
    {
        public double Radius;
        public double radius
        {
            get
            {
                return Radius;
            }
            set
            {
                radius = value;
            }
        }
        public override void area()
        {
            base.area();
            Console.WriteLine("Aylananing radiusi: " + 3.14 * radius * radius);
        }

    }
    class Uchburchak : Figure
    {
        public int A_tomoni_3;
        public int B_tomoni_3;
        public int C_tomoni_3;
        public int a_tomoni_3
        {
            get
            {
                return A_tomoni_3;
            }
            set
            {
                value = a_tomoni_3;
            }
        }
        public int b_tomoni_3
        {
            get
            {
                return B_tomoni_3;
            }
            set
            {
                value = b_tomoni_3;
            }
        }
        public int c_tomoni_3
        {
            get
            {
                return C_tomoni_3;
            }
            set
            {
                c_tomoni_3 = value;
            }
        }
        public override void perimeter()
        {
            base.perimeter();
            Console.WriteLine("Uchburchakning perimetri: " + (a_tomoni_3 + b_tomoni_3 + c_tomoni_3));
        }
        public override void area()
        {
            base.area();
            Console.WriteLine("Uchburchakning yuzasi: " + ((a_tomoni_3 * b_tomoni_3) / c_tomoni_3));
        }
    }
    class Tortburchak : Figure
    {
        public int A_tomoni_4;
        public int B_tomoni_4;
        public int a_tomoni_4
        {
            get
            {
                return A_tomoni_4;
            }
            set
            {
                a_tomoni_4 = value;
            }
        }
        public int b_tomoni_4
        {
            get
            {
                return B_tomoni_4;
            }
            set
            {
                b_tomoni_4 = value;
            }
        }
        public override void perimeter()
        {
            base.perimeter();
            Console.WriteLine("To'rtburchakning perimetri: " + (2 * (a_tomoni_4 +  b_tomoni_4)));
        }
        public override void area()
        {
            base.area();
            Console.WriteLine("To'rtburchakning yuzasi: " + (a_tomoni_4 * b_tomoni_4));
        }
    }
}
