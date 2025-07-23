namespace ConsoleApp1.GITA._20._Minimum_va_maksimumga_oid_masalalar;

public class GITAmasalalar
{
    public void Start()
    {
        Minmax1();
    }
    public void Minmax1()
    {
        Console.Write("n kiriting: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int max = 0, min = 0;
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write($"{1+i}-sonni kiriting: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if(arr[i] > max )
            {
                max = arr[i];
            }
            if(arr[i] < min || i == 0)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Max number: " + max);
        Console.WriteLine("Min number: " + min);
    }

}


