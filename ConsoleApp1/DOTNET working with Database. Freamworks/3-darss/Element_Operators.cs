namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Element_Operators
    {
        public static void Start()
        {
            //ElementAt();
            //ElementAt2();
            //First();
            //Last();

            //Single();
            Default();
        }
        public static void ElementAt()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Using Method Syntax
            var ResultMS = numbers.ElementAt(4);

            //Using Query Syntax
            var ResultQS = (from num in numbers
                            select num).
                            ElementAt(4);
            Console.WriteLine("Method Syntax: " + ResultMS);
            Console.WriteLine("Query Syntax: " + ResultQS);
        }
        public static void ElementAt2()
        {
            //Default qiymay qaytarmydi 
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Method Syntax
            var ResultMS = numbers.ElementAtOrDefault(56);
            //Query Syntax
            var ResultQS = (from num in numbers
                            select num)
                            .ElementAtOrDefault
                            (56);
            Console.WriteLine(ResultQS);
            Console.Read();
        }
        public static void First()
        {
            //bu method birinchi uchragan elementni qaytaradi
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Using Query Syntax
            var ResultQS = (from num in numbers
                            select num).First(num => num == 5);
            Console.WriteLine(ResultQS);

            //Using Method Syntax
            var ResultMS = numbers.FirstOrDefault(number => number == 5);
            Console.WriteLine(ResultMS);
        }
        public static void Last()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 };
            //Using Query Syntax
            var ResultQS = (from num in numbers
                            select num).Last(num => num == 5);

            //Using Method Syntax
            var ResultMS = numbers.LastOrDefault(number => number == 65);
            Console.WriteLine("Query Syntax: " + ResultQS);
            Console.WriteLine("Method Syntax: " + ResultMS);
        }
        public static void Single()
        {
            Employee? MethodSyntax = Employee.GetEmployees().SingleOrDefault(emp => emp.ID == 2, new Employee { Name = "Dilshod" });
            Console.WriteLine(MethodSyntax);
            Console.ReadKey();
        }
        public static void Default()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 };
            //Using Method Syntax
            var ResultMS = numbers.DefaultIfEmpty();
            foreach (var item in ResultMS)
            //{
            //    Console.Write($"{item} ");
            //}
            Console.WriteLine("\n\n");
            //Using Query Syntax
            var ResultQS = (from num in numbers
                            select num).DefaultIfEmpty().ToList();
            //foreach (var item in ResultQS)
            //{
            //    Console.Write(item + " ");
            //}
            IEnumerable<Employee>? MethodSyntax = Employee.GetEmployees().DefaultIfEmpty().ToList();
            foreach(Employee item in MethodSyntax)
            {
                Console.WriteLine(item);
            }


            Console.Read();
        }
    }
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public static List<Students> GetStudents()
        {
            return new List<Students>()
            {
                new Students  { Id = 1, Name = "Asad1", Department = "IT" },
                new Students  { Id = 2, Name = "Asad2", Department = "HR" },
                new Students  { Id = 3, Name = "Asad3", Department = "IT" },
                new Students  { Id = 4, Name = "Asad4", Department = "IT" },
                new Students  { Id = 5, Name = "Asad5", Department = "HR" }
            };
        }
    }
}
