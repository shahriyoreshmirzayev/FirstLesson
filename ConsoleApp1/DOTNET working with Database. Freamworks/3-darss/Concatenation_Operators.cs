using ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Concatenation_Operators
    {
        public static void Start()
        {
            //Concat1();
            //Concat3();
            //Union1();
            Union2();
        }
        public static void Concat1()
        {
            List<int> sequnce1 = new List<int>() { 1, 2, 3, 4 };
            List<int> sequnce2 = new List<int>() { 2, 3, 5, 6 };

            //Method Syntax
            var MS = sequnce1.Concat(sequnce2).ToList();
            //Using Query Syntax
            var QS = (from num in sequnce1
                      select num).Concat(sequnce2).ToList();
            foreach (int num in MS)
            {
                Console.Write(num + " ");
            }
            Console.Read();
        }
        public static void Concat2()
        {
            List<Student> StudentCollections1 = new List<Student>()
            {
                new Student { ID = 101, Name = "Tom" },
                new Student { ID = 101, Name = "Alex" },
                new Student { ID = 101, Name = "Hina" },
                new Student { ID = 101, Name = "Xurshid" }
            };
            List<Student> StudentCollections2 = new List<Student>()
            {
                new Student { ID = 104, Name = "Abdulatif" },
                new Student { ID = 104, Name = "Xurshid" },
                new Student { ID = 104, Name = "Jamshid" },
                new Student { ID = 104, Name = "Ahmad" }
            };

            //Using Query Syntax
            List<Student> ResultQS = (from num in StudentCollections1
                                      select num).Concat(StudentCollections2).ToList();

            //Using Method Syntax
            IEnumerable<Student> ResultMS = StudentCollections1.Concat(StudentCollections2).ToList();

        }
        public static void Concat3()
        {
            List<int> sequnce1 = new List<int>() { 1, 2, 3, 4 };
            List<int> sequnce2 = null;

            var resultMS = sequnce1.Concat(sequnce2).ToList();
            resultMS.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
        public static void Union1()
        {
            List<int> sequnce1 = new List<int>() { 1, 2, 3, 4 };
            List<int> sequnce2 = new List<int>() { 2, 3, 5, 6 };
            //Using Method Syntax
            var ResultMS = sequnce1.Union(sequnce2).ToList();
            //Using Query Syntax
            var ResultQS = (from emp in sequnce1
                            select emp)
                            .Union(sequnce2)
                            .ToList();
            Console.WriteLine("Method Syntax");
            foreach (var result in ResultMS)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine("\nQuery Syntax");
            foreach (var result in ResultQS)
            {
                Console.Write(result + " ");
            }
            Console.ReadKey();
        }
        public static void Union2()
        {
            List<Student> StudentCollections1 = new List<Student>()
            {
                new Student { ID = 101, Name = "Tom" },
                new Student { ID = 101, Name = "Alex" },
                new Student { ID = 101, Name = "Hina" },
                new Student { ID = 101, Name = "Xurshid" }
            };
            List<Student> StudentCollections2 = new List<Student>()
            {
                new Student { ID = 104, Name = "Abdulatif" },
                new Student { ID = 104, Name = "Xurshid" },
                new Student { ID = 104, Name = "Jamshid" },
                new Student { ID = 104, Name = "Ahmad" }
            };
            //Query Syntax
            var ResultQS = (from emp in StudentCollections1
                            select emp).Union(StudentCollections2).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var result in ResultQS)
            {
                {
                    Console.WriteLine($"Name: {result.Name}, ID: {result.ID}");
                }
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
    public static List<Student> GetAllStudents()
    {
        return new List<Student>()
        {
            //new Student 

        };
    }
}
