using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    class OrderBYAmaliyot
    {
        public static void OrderBY()
        {
            OrderBy_Amaliyot_1();
        }
        public static void OrderBy_Amaliyot_1()
        {
            List<int> intList = new List<int>() { 10, 23, 4565, 989, 984, 95, 12, 979487, 454, 86, 97, 23, 52, 20 };

            //Query Syntax
            var QuerySyntax = (from number in intList
                               orderby number
                               select number).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var number in QuerySyntax)
            {
                Console.Write($"{number} ");
            }
            //method Syntax
            var MethodSyntax = intList.OrderBy(x => x);
            Console.WriteLine("Method Syntax");
            foreach (var number in MethodSyntax)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
