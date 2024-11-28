namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    class OrderBYAmaliyot
    {
        public static void OrderBY()
        {
            //OrderBy_Amaliyot_1();
            //OrderByStudents();
            //OrderByDescending();
            //OrderByDescendingStudents();
            //ThenBy();
            //OrderbyComplex();
            ReversegaOidAmaliyot();
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
        public static void OrderByStudents()
        {
            //Method Syntax
            var MethodSyntax = Student.GetAllStudents().OrderBy(x => x.Branch).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var number in MethodSyntax)
            {
                Console.WriteLine("Branch: " + number.Branch + ", Name: " + number.Name + ", Age: " + number.Age + ", Male: " + number.Gender + ", ID: " + number.ID);
            }
            //Query Syntax
            Console.WriteLine("Query Syntax");
            var QuerySyntax = (from std in Student.GetAllStudents()
                               orderby std.Name
                               select std);
            foreach (var number in QuerySyntax)
            {
                Console.WriteLine("Branch: " + number.Branch + ", Name: " + number.Name + ", Gender: " + number.Gender + ", Age: " + number.Age + ", ID: " + number.ID);
            }
        }
        public static void OrderByDescending()
        {
            List<int> intList = new List<int>() { 10, 23, 4565, 989, 984, 95, 12, 979487, 454, 86, 97, 23, 52, 20 };

            //Query Syntax
            var QuerySyntax = (from number in intList
                               orderby number descending
                               select number).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var number in QuerySyntax)
            {
                Console.Write($"{number} ");
            }
            //Method Syntax
            var MethodSyntax = intList.OrderByDescending(x => x);
            Console.WriteLine("Method Syntax");
            foreach (var number in MethodSyntax)
            {
                Console.Write($"{number} ");
            }
        }
        public static void OrderByDescendingStudents()
        {
            //Method Syntax
            var MethodSyntax = Student.GetAllStudents().OrderByDescending(x => x.Branch).ToList();
            Console.WriteLine("Method Syntax Descending");
            foreach(var number in MethodSyntax)
            {
                Console.WriteLine("Branch: " + number.Gender + ", Name: " + number.Name + ", Age: " + number.Age);
            }

            //Query Syntax
            var QuerySyntax = (from std in Student.GetAllStudents()
                               orderby std.Branch descending
                               select std);
            Console.WriteLine("Query Syntax Descending");
            foreach( var number in QuerySyntax)
            {
                Console.WriteLine("Branch: " + number.Branch + ", Name: " + number.Name + ", Age: " + number.Age);
            }
        }
        public static void ThenBy()
        {
            // Using Method Syntax
            var MethoddSyntax = Student.GetAllStudents().
                OrderBy(x => x.Name).
                ThenBy(x => x.Age)
                .ToList();
            Console.WriteLine("Methos Syntax ThenBy");
            foreach (var number in MethoddSyntax)
            {
                Console.WriteLine("Name: " + number.Name + ", Age: " + number.Age);
            }
            //Using Query Syntax
            var QuerySyntax = (from std in Student.GetAllStudents()
                               orderby std.Name, std.Age
                               select std);
            Console.WriteLine("Query Syntax ThenBy");
            foreach(var number in QuerySyntax)
            {
                Console.WriteLine("Name: " + number.Name + ", Age: " + number.Age);
            }
        }
        public static void OrderbyComplex()
        {
            //Using Method Query
            var MS = Student.GetAllStudents().
                OrderBy(x => x.Name)
                .ThenBy(y => y.Age)
                .ThenByDescending(z => z.Gender)
                .ToList();
            Console.WriteLine("Method Syntax");
            foreach( var number in MS)
            {
                Console.WriteLine("Name: " + number.Name + ", Age: " + number.Age + ", Gender: " + number.Gender);
            }
            //Using Query Syntax
            var QS = (from std in Student.GetAllStudents()
                      orderby std.Branch ascending,
                      std.Name ascending,
                      std.Age descending
                      select std).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var number in QS)
            {
                Console.WriteLine("Branch: " + number.Branch + ", Name: " + number.Name + ", Age: " + number.Age);
            }
        }
        public static void ReversegaOidAmaliyot()
        {
            int[] newArray = new int[] { 10, 20, 16, 1000, 70, 150, 20 };
            Console.WriteLine("Before Reverse the Data");
            foreach (var number in newArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
            //Using Method Syntax
            IEnumerable<int> ReverseDataMethodSyntax = newArray.Reverse();
            Console.WriteLine("Method Syntax the Reverse array");
            foreach(var number in ReverseDataMethodSyntax)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
            //Using Query Syntax
            IEnumerable<int> ReverseDataQuerySyntax = (from number in newArray
                                                       select number).Reverse();
            Console.WriteLine("Query Syntax the Reverse array");
            foreach( var number in ReverseDataQuerySyntax)
            {
                Console.Write($"{number} ");
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1001, Name = "Azamat", Gender = "Male", Branch = "Shahar", Age = 19 },
                new Student { ID = 1002, Name = "Dilshod", Gender = "Male", Branch = "Tuman", Age = 24 },
                new Student { ID = 1003, Name = "Jo'rabek", Gender = "Male", Branch = "Viloyat", Age = 20 },
                new Student { ID = 1004, Name = "Lola", Gender = "Female", Branch = "Qishloq", Age = 35 }
            };
        }
    }
}
