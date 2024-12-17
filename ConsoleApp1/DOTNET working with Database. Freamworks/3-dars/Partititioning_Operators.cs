
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

            TakeWhile1();
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
