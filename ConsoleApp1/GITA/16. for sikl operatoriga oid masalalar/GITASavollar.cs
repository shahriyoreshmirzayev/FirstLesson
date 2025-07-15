namespace ConsoleApp1;

public class GITASavollar
{
    public void Start()
    {
    Start:
        //Masala1();
        //Masala2();
        //Masala3();
        //Masala4();
        //Masala5();
        //Masala6();
        //For1();
        //For2();
        //For3();
        //For4();
        //For5();      //Error
        //For6();      //Error
        //For7();
        //For8();
        //For9();
        //For10();
        //For11();
        For12();
        //For13();
        //For14();
        //For15();
        //For16();
        //For17();
        //For18();
        //For19();
        //For20();
        //For21();
        //For22();
        //For23();
        //For24();
        //For25();
        //For26();
        //For27();
        //For28();
        //For29();
        //For30();
        //For31();
        //For32();
        //For33();
        //For34();
        //For35();
        //For36();
        //For37();
        //For38();
        //For39();
        //For40();
        goto Start;
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
        for (int i = 1; i <= number; i++)
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
        for (int i = 1; i <= number; i++)
        {
            count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
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
        for (int i = 1; i <= number1; i++)
        {
            if (number1 % i == 0 && number2 % i == 0)
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
        for (int i = 1; i <= number1 * number2; i++)
        {
            if (i % number1 == 0 && i % number2 == 0)
            {
                ekuk = i;
                break;
            }
        }
        Console.WriteLine($"Ekuk: {ekuk}");
        Console.Read();
    }
    public void For1()
    {
        Console.Write("Enter number(k): ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number(n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{k} ");
        }
    }
    public void For2()
    {
        Console.Write("Enter number(a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number(b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            Console.Write($"{i} ");
            count++;
        }
        Console.WriteLine("\n Sanoq = " + count);
    }
    public void For3()
    {
        Console.Write("Enter number(a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number(b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = b - 1; i > a; i--)
        {
            Console.Write($"{i} ");
            count++;
        }
        Console.WriteLine("\n Sanoq = " + count);
    }
    public void For4()
    {
        Console.Write("Konfet narxini kiriting: ");
        int price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Konfet sonini kiriting: ");
        int count = Convert.ToInt32(Console.ReadLine());
        int multi = 1;
        for (int i = 1; i <= count; i++)
        {
            multi += i * price;
        }
        Console.WriteLine($"Konfetning jami narxi: {multi} so'm");
    }
    public void For5()
    {
        Console.Write("Konfet narixini kiriting: ");
        int price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Konfet kilosini kiriting: ");
        double kilo = Convert.ToDouble(Console.ReadLine());
        double multi = 1;
        for (double i = 0.1; i <= kilo; i += 0.1)
        {
            multi = i * price;
        }
        Console.WriteLine($"Konfetning jami narxi: {multi} so'm");
    }
    public void For6()
    {

    }
    public void For7()
    {
        Console.Write("Enter number(a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number(b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i = a; i <= b; i++)
        {
            count += i;
        }
        Console.WriteLine($"Natija: {count}");
    }
    public void For8()
    {
        Console.Write("Enter number(a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number(b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int multi = 1;
        for (int i = a; i <= b; i++)
        {
            multi *= i;
        }
        Console.WriteLine($"Natija: {multi}");
    }
    public void For9()
    {
        Console.Write("Enter number(a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number(b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int multi = 0;
        for(int i = a; i <= b; i++)
        {
            multi += i * i;
        }
        Console.WriteLine($"Natija: {multi}");
    }
    public void For10()
    {
        Console.Write("Enter number(n): ");
        double n = Convert.ToInt32(Console.ReadLine());
        double count = 0;
        for(double i = 1; i <= n; i++)
        {
            count += 1 / i;
        }
        Console.WriteLine("Natija: " + count);
    }
    public void For11()
    {
        Console.Write("Enter number(n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i = n; i <= 2 * n; i++)
        {
            count += i * i;
        }
        Console.WriteLine($"Natija: {count}");
    }
    public void For12()
    {
        Console.Write("Enter number(n): ");
        double n = Convert.ToDouble(Console.ReadLine());
        double multi = 1;
        for(double i = 1.1; i <= n; i += 0.1)
        {
            multi *= i;
        }
        Console.WriteLine($"Natija: {multi}");
    }
    public void For13()
    {

    }
    public void For14()
    {

    }
    public void For15()
    {

    }
    public void For16()
    {

    }
    public void For17()
    {

    }
    public void For18()
    {

    }
    public void For19()
    {

    }
    public void For20()
    {

    }
    public void For21()
    {

    }
    public void For22()
    {

    }
    public void For23()
    {

    }
    public void For24()
    {

    }
    public void For25()
    {

    }
    public void For26()
    {

    }
    public void For27()
    {

    }
    public void For28()
    {

    }
    public void For29()
    {

    }
    public void For30()
    {

    }
    public void For31()
    {

    }
    public void For32()
    {

    }
    public void For33()
    {

    }
    public void For34()
    {

    }
    public void For35()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

    }
    public void For36()
    {
        Console.Write("Enter number(n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number(k): ");
        int k = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            int multi = 1;
            for (int j = 1; j <= k; j++)
            {
                multi *= i;
            }
            count += multi;
        }
        Console.WriteLine($"Natija: {count}");
    }
    public void For37()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            int multi = 1;
            for (int j = 1; j <= i; j++)
            {
                multi *= i;
            }
            count += multi;
        }
        Console.WriteLine($"Natija: {count}");
    }
    public void For38()
    {
    Shahriyor:
        Console.Write("Enter nuumber: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            int multi = 1;
            int power = n - i + 1;
            for (int j = 0; j < power; j++)
            {
                multi *= i;
            }
            count += multi;
        }
        Console.WriteLine($"Natija: {count}");
        goto Shahriyor;
    }
    public void For39()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i} ");
            }
        }
    }
    public void For40()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i - a + 1; j++)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
