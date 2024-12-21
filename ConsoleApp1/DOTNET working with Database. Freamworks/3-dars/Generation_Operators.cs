using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Generation_Operators
    {
        public static void Start()
        {
            Empty1();
        }
        public static void Empty1()
        {
            IEnumerable<string> emtyCollection1 = Enumerable.Empty<string>();


            Console.WriteLine("Count: {0} " + emtyCollection1.Count());
            Console.WriteLine("Type: {0} " + emtyCollection1.GetType());
        }
    }
}
