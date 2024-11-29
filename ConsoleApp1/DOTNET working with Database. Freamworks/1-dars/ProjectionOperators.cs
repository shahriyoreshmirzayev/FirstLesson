using NCalc;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    public static class ProjectionOperators
    {
        public static void Start()
        {
            //Where();
            //WhereWithMethod();
            WhereWithIndexPosition();
        }
        public static void Where()
        {
            List<int> intList = new List<int>() { 1, 15, 26, 5, 3, 4, 12, 30, 14, 24 };
            //Method Syntax
            IEnumerable<int> methodSyntax = intList.Where(x => x > 5); // bu yerda shartlar berishimiz mumkin
            Console.WriteLine("Method Syntax");
            foreach (int i in methodSyntax)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            //Query Syntax
            IEnumerable<int> querySyntax = (from num in intList
                                            where num > 5 //bu yerda shartlar berishim mumkin qo'shimcha
                                            select num).ToList();
            Console.WriteLine("Query Syntax");
            foreach (int i in querySyntax)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
        public static void WhereWithMethod()
        {
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //Method Syntax
            IEnumerable<int> filterData = intList.Where(x => CheckNumber(x));
            Console.WriteLine("Method Syntax");
            foreach (int i in filterData)
            {
                Console.WriteLine($"{i}");
            }

            //Query Syntax
            IEnumerable<int> filterDataM = (from num in intList
                                            where CheckNumber(num)
                                            select num).ToList();

            Console.WriteLine("Query Syntax");
            foreach (int i in filterDataM)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
        public static bool CheckNumber(int number)
        {
            if (number > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void WhereWithIndexPosition()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //Method Syntax
            var MethodSyntaxPosition = intList.Select((num, index) => new
            {
                Numbers = num,
                IndexPosition = index
            }).Where(x => x.Numbers % 2 == 1)
            .Select(data => new
            {
                Number = data.Numbers,
                IndexPosition = data.IndexPosition
            });
            Console.WriteLine("Method Syntax");
            foreach (var item in MethodSyntaxPosition)
            {
                Console.WriteLine($"Index: {item.IndexPosition} => Number: {item.Number}");
            }


            //Query Syntax
            var QuerySyntaxPosition = (from number in intList.Select((num, index) => new { Numbers = num, IndexPosition = index })
                                       where number.Numbers % 2 == 0
                                       select new
                                       {
                                           Numbers = number.Numbers,
                                           IndexPosition = number.IndexPosition
                                       });
            Console.WriteLine("Query Syntax");
            foreach (var item in QuerySyntaxPosition)
            {
                Console.WriteLine($"Index :{item.IndexPosition} => Number: {item.Numbers}");
            }
            Console.ReadKey();
        }
    }
}
