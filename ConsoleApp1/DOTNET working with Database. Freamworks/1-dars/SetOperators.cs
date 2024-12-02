namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    internal class SetOperators
    {
        public static void Start()
        {
            //Distinct1();
            //Distinct2();
            //Distinct3();
            //Distinct4();

            //Except1();
            Except2();
        }
        public static void Distinct1()
        {
            List<int> intList = new List<int>()
            {
                1, 2, 2, 2, 3, 3, 3, 3, 3, 4, 5, 5, 5, 6, 6, 6, 6, 6, 7, 7, 7, 8, 8, 9
            };
            //Query Syntax
            var querySyntax = (from number in intList
                               select number).Distinct();
            Console.WriteLine("Query Syntax");
            foreach (var number in querySyntax)
            {
                Console.Write($"{number} ");
            }
            //Method Syntax
            var methodSyntax = intList.Distinct();
            Console.WriteLine("\nMethod Syntax");
            foreach (var number in methodSyntax)
            {
                Console.Write($"{number} ");
            }
        }
        public static void Distinct2()
        {
            string[] stringarray = { "PDP", "Shahriyor", "pdp", "azamat", "shahriyor", "AZAMAT", "Salom PDP" };
            //Method Syntax
            var methodSyntax = stringarray.Distinct(StringComparer.OrdinalIgnoreCase);
            Console.WriteLine("Method Syntax");
            foreach (var number in methodSyntax)
            {
                Console.WriteLine($"string: {number}");
            }
            //Query Syntax
            var querySyntax = (from number in stringarray
                               select number).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var number in querySyntax)
            {
                Console.WriteLine($"string: {number}");
            }
            Console.ReadKey();
        }
        public static void Distinct3()
        {
            //Method Syntax
            var methodSyntax = Student.GetAllStudents()
                .Select(x => x.Name)
                .Distinct().ToList();
            Console.WriteLine("Method Syntax");
            foreach (var number in methodSyntax)
            {
                Console.WriteLine($"Name: {number}");
            }
            //Query Syntax
            var querySyntax = (from student in Student.GetAllStudents()
                               select student.Name).Distinct().ToList();
            Console.WriteLine("Query Syntax");
            foreach (var item in querySyntax)
            {
                Console.WriteLine($"Name: {item}");
            }
            Console.Read();
        }
        public static void Distinct4()
        {
            //Using Method Syntax
            var methodSyntax = Student.GetAllStudents()
                .Select(x => x.Name)
                .Distinct().ToList();
            Console.WriteLine("Method Syntax");
            foreach(var student in methodSyntax)
            {
                Console.WriteLine(student);
            }
            //Using Query Syntax
            var querySyntax = (from student in Student.GetAllStudents()
                               select student.Name).Distinct().ToList();
            Console.WriteLine("Query Syntax");
            foreach( var student in querySyntax)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();     
        }
        public static void Except1()
        {
            List<int> intList1 = new List<int>() { 1, 2, 3, 4, 8, 9, 10 };
            List<int> intList2 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //Using Query Syntax
            var querySyntax = (from student in intList1
                               select student)
                               .Except(intList2).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var student in querySyntax)
            {
                Console.Write(student + "  ");
            }
            Console.ReadKey();
        }
        public static void Except2() {
            List<Student> AllStudents = new()
            {
                new Student { ID = 101, Name = "Xurshid" },
                new Student { ID = 102, Name = "Jamol" },
                new Student { ID = 103, Name = "Xojiakbar" },
                new Student { ID = 104, Name = "Kamol" },
                new Student { ID = 105, Name = "Olim" },
                new Student { ID = 106, Name = "Adham" },
            };
            List<Student> Class6Student = new()
            {
                new Student {ID = 102, Name = "Jamol" },
                new Student {ID = 104, Name = "Kamol" },
                new Student {ID = 105, Name = "Olim" }
            };
            //Method Syntax
            var methodSyntax = AllStudents.Except(Class6Student).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var student in methodSyntax)
            {
                Console.WriteLine($"Name: {student.Name}, ID => {student.ID}");
            }
        }
    }
}
