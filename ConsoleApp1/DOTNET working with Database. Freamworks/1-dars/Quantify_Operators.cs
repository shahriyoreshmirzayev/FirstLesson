using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    internal class Quantify_Operators
    {
        public static void Start()
        {
            All1();
        }
        public static void All1()
        {
            int[] massiv = new int[] { 14, 19, 13, 11, 21, 45, 3, 12, 7 };

            //Using Method Syntax
            bool methodSyntax = massiv.All(x => x > 2);
            Console.WriteLine("Method Syntax");
            Console.WriteLine($"Massivdagi barcha elementlar 10 sonidan katta-mi?: {methodSyntax}");

            //Using Method Syntax
            bool querySyntax = (from x in massiv
                                select x).All(x => x > 2);
            Console.WriteLine("Query Syntax");
            Console.WriteLine("Massivdagi barcha elementlar 2 sonidan katta-mi?: " + querySyntax);
        }
    }
}
