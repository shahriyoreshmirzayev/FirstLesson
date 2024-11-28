namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    class OrderBYAmaliyot
    {
        public static void OrderBY()
        {
            //OrderBy_Amaliyot_1();
            OrderByStudents();
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
            /*Console.WriteLine("Query Syntax");
            var QuerySyntax = (from std in Student.GetAllStudents()
                               orderby std.Branch
                               select std);
            foreach (var number in QuerySyntax)
            {
                Console.WriteLine("Branch: " + number.Branch + ", Name: " + number.Name + ", Gender: " + number.Gender + ", Age: " + number.Age + ", ID: " + number.ID);
            }*/
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
