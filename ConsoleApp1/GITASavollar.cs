namespace ConsoleApp1;

public class GITASavollar
{
    public void Start()
    {
        //Masala1();
        //Masala2();
        //Masala3();
        //Masala4();
        //Masala5();
        Masala6();
    }
    public void Masala1()
    {
        Console.Write("Son kiriting: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = number; i > 0; i /= 10)
        {
            count += i % 10;
        }
        Console.WriteLine($"Sonning raqamlar yig'indisi: {count}");
    }
    public void Masala2()
    {
        Console.Write("Sonni kiriting: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        string str = number1.ToString();
        string s = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            s += str[i];
        }
        Console.WriteLine($"Sonning teskari ko'rinishi: {s}");
    }
    public void Masala3()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine($"{number} soni tub sondir.");
        }
        else
        {
            Console.WriteLine($"{number} soni tub son emas.");
        }
    }
    public void Masala4()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i = 1; i <= number; i++)
        {
            count = 0;
            for(int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.Write($"{i} ");
            }
        }
        Console.Read();
    }
    public void Masala5()
    {
        Console.Write("Enter number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int ekub = 1;
        for(int i = 1; i <= number1; i++)
        {
            if(number1 % i == 0 && number2 % i == 0)
            {
                ekub = i;
            }
        }
        Console.WriteLine($"Ekub: {ekub}");
        Console.Read();
    }
    public void Masala6()
    {
        Console.Write("Enter number1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int ekuk = 1;
        for(int i = 1; i <= number1 * number2; i++)
        {
            if(i % number1 == 0 && i % number2 == 0)
            {
                ekuk = i;
                break;
            }
        }
        Console.WriteLine($"Ekuk: {ekuk}");
        Console.Read();
    }
}
