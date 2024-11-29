namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    public static class ProjectionOperators
    {
        public static void Start()
        {
            //Where();
            //WhereWithMethod();
            //WhereWithIndexPosition();
            //WhereWithEmployee();
            WhereWithEmployee2();
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
        public static void WhereWithEmployee()
        {
            //Query Syntax
            var querySyntax = from employee in Employee.GetEmployees()
                              where employee.Salary > 10000 && employee.FirstName == "Dilshod"
                              select employee;
            Console.WriteLine("Query Syntax");
            foreach (var item in querySyntax)
            {
                Console.WriteLine($"Name: {item.FirstName}, Salary: {item.Salary}");
            }

            //Method Syntax
            var methodSyntax = Employee.GetEmployees()
                .Where(emp => emp.Salary > 10000);
            Console.WriteLine("Method Syntax");
            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"Name: {item.FirstName}, Surname: {item.LastName}, Salary: {item.Salary}");
            }
            Console.ReadLine();
            Console.ReadKey();
        }
        public static void WhereWithEmployee2()
        {
            //Query Syntax
            var querySyntax = from employee in Employee.GetEmployees()
                              where employee.Salary > 15000 && employee.Programming.Contains("C#")
                              select employee;

            //Method Syntax
            var methodSyntax = Employee.GetEmployees()
                .Where(emp => emp.Salary > 15000 && emp.Programming.Contains("C#"))
                .ToList();

            Console.WriteLine("Query Syntax");
            foreach (var item in querySyntax )
            {
                Console.WriteLine($"Salary: {item.Salary}, Name: {item.FirstName}");
                foreach (var programm in item.Programming)
                {
                    Console.Write($"{programm} ");
                }
            }
            Console.WriteLine("\n\n\nMethod Syntax");
            foreach(var item in methodSyntax)
            {
                Console.WriteLine($"Salary: {item.Salary}, Name: {item.FirstName}");
                foreach (var programm in item.Programming)
                {
                    Console.Write($"{programm} ");
                }
            }
            Console.ReadKey ();
        }
    }
}
