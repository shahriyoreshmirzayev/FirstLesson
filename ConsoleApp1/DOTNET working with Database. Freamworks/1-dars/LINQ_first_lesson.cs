namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    public static class LINQ_first_lesson
    {
        public static void Start()
        {
            //Select();
            //SelectFewProperties();
            //SelectAnonymousType();
            //SelectCalculation();
            //SelectMany();
            SelectManyExample();
        }
        public static void Select()
        {
            //Using Query Syntax
            /* IEnumerable<int> basicPropQuery = (from emp in Employee.GetEmployees()
                                         select emp.ID).ToList();
             Console.WriteLine("Query Syntax");
             foreach (var id in basicPropQuery)
             {
                 Console.WriteLine($"ID: {id}");
             }*/

            IEnumerable<int> basicPropMethod = Employee.GetEmployees()
                .Select(emp => emp.ID);
            Console.WriteLine("Method Syntax");
            foreach (var id in basicPropMethod)
            {
                Console.WriteLine($"ID: {id}");
            }
        }
        public static void SelectFewProperties()
        {
            //Query Syntax
            IEnumerable<Employee> selectQuery = (from emp in Employee.GetEmployees()
                                                 select new Employee()
                                                 {
                                                     FirstName = emp.FirstName,
                                                     LastName = emp.LastName,
                                                     Salary = emp.Salary,
                                                 });
            Console.WriteLine("Query Syntax");
            foreach (var emp in selectQuery)
            {
                Console.WriteLine($"Name :{emp.FirstName} {emp.LastName} : {emp.Salary}");
            }

            //Method Syntax
            List<Employee> selectMethod = Employee.GetEmployees()
                .Select(emp => new Employee()
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary,
                }).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($"Name : {emp.FirstName} {emp.LastName}: {emp.Salary}");
            }

        }
        public static void SelectAnonymousType() // anonim sifatida tiplarni qaytarmoqda
        {
            //Query Syntax
            var selectQuery = from emp in Employee.GetEmployees()
                              select new
                              {
                                  FirstName = emp.FirstName,
                                  LastName = emp.LastName,
                                  Salary = emp.Salary,
                              };
            Console.WriteLine("Query Syntax");
            foreach (var emp in selectQuery)
            {
                Console.WriteLine($"Name: {emp.FirstName} {emp.LastName} : {emp.Salary}");
            }
            //Method Syntax
            var selectMethod = Employee.GetEmployees()
                .Select(emp => new
                {
                    Employee_ID = emp.ID,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Salary = emp.Salary,
                });
            Console.WriteLine("Method Syntax");
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($"Name: {emp.FirstName} {emp.LastName} : {emp.Salary}, ID : {emp.Employee_ID}");
            }
        }
        public static void SelectCalculation()
        {
            //Query Syntax
            var selectQuery = (from emp in Employee.GetEmployees()
                               select new
                               {
                                   Employee_ID = emp.ID,
                                   FullName = emp.FirstName + "  " + emp.LastName,
                                   AnnualSalary = emp.Salary * 12,
                               });
            Console.WriteLine("Query Syntax");
            foreach (var emp in selectQuery)
            {
                Console.WriteLine($"ID: {emp.Employee_ID} Name : {emp.FullName}, Annual Salary : {emp.AnnualSalary}");
            }



            //Method Syntax
            var selectMethod = Employee.GetEmployees()
                .Select(emp => new
                {
                    Employee_ID = emp.ID,
                    FullName = emp.FirstName + "  " + emp.LastName,
                    AnnualSalary = emp.Salary * 12
                }).ToList();
            Console.WriteLine("Method Syntax");
            foreach( var emp in selectMethod)
            {
                Console.WriteLine($"ID :{emp.Employee_ID}, Name : {emp.FullName}, Annual Salary {emp.AnnualSalary}");
            }
        }
        public static void SelectMany()
        {
            //Query Syntax
            List<string> nameList = new List<string>() { "Dilshod", "Shodiyev" };

            IEnumerable<char> querySyntax = from str in nameList
                                            from ch in str
                                            select ch;
            foreach (var ch in querySyntax)
            {
                Console.Write($"{ch} ");
            }
        }
        public static void SelectManyExample()
        {
            //Using Method Syntax
            List<string> MethodSyntax = Employee.GetEmployees().SelectMany(std => std.Programming).ToList();

            //Using Query Syntax
            IEnumerable<string> QuerySyntax = from emp in Employee.GetEmployees()
                                              from program in emp.Programming
                                              select program;
            Console.WriteLine("Query Syntax");
            foreach (var emp in QuerySyntax)
            {
                Console.Write($"{emp} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Method Syntax");
            foreach (var emp in MethodSyntax)
            {
                Console.Write($"{emp} ");
            }
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double Salary { get; set; }
        public List<string> Programming { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new()
            {
                new() {ID = 101, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 100000, Programming = new List<string> { "C++", "C#", "Java" } },
                new() {ID = 102, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 200000, Programming = new List<string> { "Flutter", "C#", "Python" } },
                new() {ID = 103, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 300000, Programming = new List<string> { "Python", "C#", "C++" } },
                new() {ID = 104, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 400000, Programming = new List<string> { "Go", "C#", "C" } },
                new() {ID = 105, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 500000, Programming = new List<string> { "Java Script", "Git", "Python" } },
                new() {ID = 106, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 600000, Programming = new List<string> { "Database", "C#", "PHP" } }
                };
            return employees;
        }
    }
}

