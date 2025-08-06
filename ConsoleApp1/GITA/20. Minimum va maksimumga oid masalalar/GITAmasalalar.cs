using Npgsql.EntityFrameworkCore.PostgreSQL.Query.ExpressionTranslators.Internal;

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
        Masala12();
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
        {
            if (str[i] == 'a')
            {
                str = str.Remove(i, 1).Insert(i, "b");
            }
            else if (str[i] == 'b')
            {
                str = str.Remove(i, 1).Insert(i, "a");
            }
        }
        Console.WriteLine(str);

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


