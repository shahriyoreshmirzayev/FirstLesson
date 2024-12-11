namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._2_dars
{
    internal class Groupping_Operators
    {
        public static void Start()
        {
            GroupBy1();
        }
        public static void GroupBy1()
        {
            //Using Method Syntax
            IEnumerable<IGrouping<string, Student>> GroupByMS = Student.GetStudents().GroupBy(x => x.Gender);
            Console.WriteLine("Method Syntax");
            foreach (IGrouping<string, Student> group in GroupByMS)
            {
                Console.WriteLine(group.Key + ": " + group.Count());
                foreach (var student in group)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch}");
                }
            }

            //Using Query Syntax
            IEnumerable<IGrouping<string,Student>> GroupByQS = (from std in Student.GetStudents()
                                                                select std as Student).GroupBy(x => x.Branch);
            Console.WriteLine("Query Syntax");
            foreach(IGrouping<string, Student> group in GroupByQS)
            {
                Console.WriteLine(group.Key + ": " + group.Count());
                foreach (var student in group)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}");
                }
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
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student { ID = 1001, Name = "Alisher", Gender = "Male", Branch = "CSE", Age = 19 },
                new Student { ID = 1002, Name = "Xadicha", Gender = "FeMale", Branch = "CSE", Age = 26 },
                new Student { ID = 1003, Name = "Hikmat", Gender = "Male", Branch = "ETC", Age = 18 },
                new Student { ID = 1004, Name = "Dilnoza", Gender = "FeMale", Branch = "CSE", Age = 35 },
                new Student { ID = 1005, Name = "Kamron", Gender = "Male", Branch = "ETC", Age = 17 },
                new Student { ID = 1006, Name = "Madina", Gender = "FeMale", Branch = "CSE", Age = 23 },
                new Student { ID = 1007, Name = "Zaynab", Gender = "FeMale", Branch = "ETC", Age = 24 },
                new Student { ID = 1008, Name = "Mushtariy", Gender = "FeMale", Branch = "CSE", Age = 29 },
                new Student { ID = 1009, Name = "Ilyos", Gender = "Male", Branch = "CSE", Age = 30 },
                new Student { ID = 1010, Name = "Zufar", Gender = "Male", Branch = "ETC", Age = 18 },
            };
        }
    }
}
