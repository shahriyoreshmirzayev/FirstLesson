using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Partititioning_Operators
    {
        public static void Start()
        {
            //Take1();
            Take2();
        }
        public static void Take1()
        {
            //Dinamik ko'rinishda
            Console.Write("Qancha son chiqishini xohlaysiz raqamlarda kiriting: ");
            var a = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            //Using Method Syntax
            IEnumerable<int> ResultMS = numbers.Take(a);
            Console.WriteLine("Method Syntax");
            foreach (int i in ResultMS)
            {
                Console.WriteLine($"Belgilangan sonlar: {i}");
            }
            //Using Query Syntax
            IEnumerable<int> ResultQS = (from x in numbers
                                         select x).Take(a).ToList();
            Console.WriteLine("Query Syntax");
            foreach(int i in ResultQS)
            {
                Console.WriteLine("Belgilangan sonlar: " + i);
            }
            Console.Read();
        }
        public static void Take2()
        {
            //Dinamik ko'rinishda
            Console.Write("Qancha son chiqishini xohlaysiz raqamlarda kiriting: ");
            var a = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            //Using Method Syntax
            var ResultMS = numbers.Where(num => num > 4).Take(a).ToList();
            Console.WriteLine("Method Syntax");
            foreach (int i in ResultMS)
            {
                Console.WriteLine("Raqam: " + i);
            }

            //Using Query Syntax
            var ResultQS = (from x in numbers
                            where x > 4
                            select x).Take(a).ToList();
            Console.WriteLine("Query Syntax");
            foreach(var x in ResultQS)
            {
                Console.WriteLine($"Raqam: {x}");
            }
            Console.Read();
        }
    }
}
