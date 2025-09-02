namespace ConsoleApp1.GITA._20._Minimum_va_maksimumga_oid_masalalar;

public class GITAmasalalar
{
    public void Start()
    {
        //Minmax1();
        //Masala8();
        //Masala9();
        //Masala10();
        //Masala11();
        //Masala12();
        //Masala13();
        //Masala14();
        //Masala15();
        //Masala16();
        //Masala195();
        Masala2();
    }
    public void Masala1()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (i >= j)
                {
                    Console.Write(j+n);
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
    public void Masala2()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j + n);
            }
            for (int j = i + 1; j < n; j++)
            {
                Console.Write("  ");
            }
            Console.WriteLine();
        }

    }
    public void Masala195()
    {
        Console.Write("Enter str: ");
        string str = Console.ReadLine();
        int number1 = -1, number2 = -1, count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i])) 
            {
                count++;
                if (count == 1)
                {
                    number1 = int.Parse(str[i].ToString());
                }
                else if (count == 2)
                {
                    number2 = int.Parse(str[i].ToString());
                    break; 
                }
            }
        }
        Console.WriteLine(number1);
        Console.WriteLine(number2);
        for(int i = 1; i <= number1 * number2; i++)
        {
            if(i % number1 == 0 && i % number2 == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
    public void Masala16()
    {
        for(int i = 5; i >= 1; i--)
        {
            for(int j = 0; j < 5 - i; j++)
            {
                Console.Write("  ");
            }
            Console.WriteLine(i);
        }
    }
    public void Masala15()
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                Console.Write("  ");
            }

            Console.WriteLine(i);
        }
    }
    public void Masala8()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1 || i == n / 2)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
    public void Masala9()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j <= 2 || i + j >= 6 || i - j >= 2 || i - j <= -2)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
    public void Masala10()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!(i + j == 0 || i + j == 2 || i + j == 4 || i + j == 6 || i + j == 8))
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
    public void Masala11()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j != 1 && i + j != 7 && i - j != 3 && i - j != -3)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
    public void Masala12()
    {
        Console.Write("Enter word: ");
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
            if (str[i] == 'a')
                str = str.Remove(i, 1).Insert(i, "b");
            else if (str[i] == 'b')
                str = str.Remove(i, 1).Insert(i, "a");
        Console.WriteLine(str);

    }
    public void Masala13()
    {
        Console.Write(" Enter any text ");
        string word = Console.ReadLine();
        string result = " ";

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'a')
            {
                result += 'b';
            }
            else if (word[i] == 'b')
            {
                result += 'a';
            }
            else
            {
                result += word[i];
            }
        }
        Console.WriteLine(result);

    }
    public void Masala14()
    {


    }
    public void Minmax1()
    {
        int n;
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

    }

}


