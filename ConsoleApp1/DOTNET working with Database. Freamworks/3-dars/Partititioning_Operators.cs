
namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    public class Partititioning_Operators
    {
        public static void Start()
        {
            //Take1();
            //Take2();
            //Take3();
            //Take4();

            //TakeWithException();

            //TakeWhile1();
            //TakeWhile2();
            //TakeWhile3();
            TakeWhile4();
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
            foreach (int i in ResultQS)
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
            foreach (var x in ResultQS)
            {
                Console.WriteLine($"Raqam: {x}");
            }
            Console.Read();
        }
        public static void Take3()
        {
            //Dinamik ko'rinishda
            Console.Write("Qancha son chiqishini xohlaysiz raqamlarda kiriting: ");
            var a = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            //Using Method Syntax
            var ResultMS = numbers.Where(num => num > 4).Take(a).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var num in ResultMS)
            {
                Console.Write(num + " ");
            }

            //Using Query Syntax
            var ResultQS = (from x in numbers
                            where x > 4
                            select x).Take(a).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var i in ResultQS)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
        public static void Take4()
        {
            //Data Source
            List<Employee> employees = Employee.GetEmployees();
            //Using Method Syntax
            var ResultMS = employees.OrderByDescending(emp => emp.Salary).Take(3).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var emp in ResultMS)
            {
                Console.WriteLine($"Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");
            }

            //Using Query Syntax
            var ResultQS = (from emp in Employee.GetEmployees()
                            orderby emp.Salary descending
                            select emp)
                            .Take(3).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var item in ResultQS)
            {
                Console.WriteLine($"Name: {item.Name}, ID: {item.ID}, Gender: {item.Gender}");
            }
            Console.Read();
        }
        public static void TakeWithException()
        {
            List<int> numbers = null;

            //Using Method Syntax
            var ResultMS = numbers.Take(5).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var x in ResultMS)
            {
                Console.WriteLine(x);
            }
            //Using Query Syntax
            var ReslutQS = (from x in numbers
                            select x)
                           .Take(5).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var x in ReslutQS)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
        public static void TakeWhile1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            //Using Method Syntax
            List<int> ResultMS = numbers.TakeWhile(num => num < 6).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            //Using Query Syntax
            List<int> ReslutQS = (from num in numbers
                                  select num)
                                 .TakeWhile(num => num < 6)
                                 .ToList();
            Console.WriteLine("Query Syntax");
            foreach (var num in ReslutQS)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
        public static void TakeWhile2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            Console.Write("Sonni kiriting: ");
            var a = int.Parse(Console.ReadLine());

            //Using Method Syntax Qirovxon
            var Qirovxon_Method_Syntax = numbers.Where(num => num < a).ToList();
            Console.WriteLine("Qirovxon bo'yicha Method Syntax");
            foreach (var x in Qirovxon_Method_Syntax)
            {
                Console.Write(x + " ");
            }

            //Using Query Syntax Oyxon
            var Oyxon_Query_Syntax = (from x in numbers
                                      select x)
                                      .Where(num => num < a).ToList();
            Console.WriteLine("\nOyxon bo'yicha Method Syntax");
            foreach(var x in Oyxon_Query_Syntax)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
        public static void TakeWhile3()
        {
            List<int> numbers = new List<int>() { 1, 2, 36, 4, 21, 6, 10, 8, 9, 5, 11, 12, 45, 23, 18, 16, 14, 18 };

            //Using Method Syntax
            var ResultMS = numbers.TakeWhile(num => num < 4).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var x in ResultMS)
            {
                Console.Write(x + " ");
            }

            //Using Query Syntax
            var ResultQS = (from x in numbers
                            select x).TakeWhile(num => num < 4).ToList();
            Console.WriteLine("\nQuery Syntax");
            foreach (var x in ResultQS)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
        public static void TakeWhile4()
        {
            List<string> name = new List<string>()
            {
                "Aziz",
                "Sarvar",
                "Jasur",
                "Saidakbar",
                "Joe",
                "Pol",
                "Laziz",
                "Shahriyor",
                "Azamat",
                "Fotima",
                "Mahliyo"
            };
            //Method Syntax
            var ResultMS = name.TakeWhile(num => num.Length > 3).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var x in ResultMS)
            {
                Console.Write(x + " ");
            }

            //Using Query Syntax
            var ResultQS = (from x in name
                            select x)
                            .TakeWhile(num =>num.Length > 3).ToList();
            Console.WriteLine("\nQuery Syntax");
            foreach(var x in ResultQS)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
                {
                new Employee { ID = 1, Name = "Asadbek", Gender = "Male", Salary = 10000 },
                new Employee { ID = 2, Name = "Jasurbek", Gender = "Male", Salary = 40000 },
                new Employee { ID = 3, Name = "Munisa", Gender = "FeMale", Salary = 60000 },
                new Employee { ID = 4, Name = "Nilufar", Gender = "FeMale", Salary = 50000 },
                new Employee { ID = 5, Name = "Islom", Gender = "Male", Salary = 27000 },
                new Employee { ID = 6, Name = "Nurilloh", Gender = "Male", Salary = 35000 },
                new Employee { ID = 7, Name = "Ilhom", Gender = "Male", Salary = 30000 },
                new Employee { ID = 8, Name = "Behzod", Gender = "Male", Salary = 15000 }
                };
        }
        //internal static List<Employee> GetAllEmployees()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
