namespace ConsoleApp1;

public class GITASavollar
{
    public void Start()
    {
        //Masala1();
        Masala2();
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
}
