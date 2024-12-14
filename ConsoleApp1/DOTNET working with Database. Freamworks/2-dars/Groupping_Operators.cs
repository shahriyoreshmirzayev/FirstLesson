namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._2_dars
{
    class Groupping_Operators
    {
        public static void Start()
        {
            //GroupBy1();
            //GroupBy2();
            //GroupBy3();

            //GroupByInto1();
            GroupByInto2();
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
            IEnumerable<IGrouping<string, Student>> GroupByQS = (from std in Student.GetStudents()
                                                                 select std as Student).GroupBy(x => x.Branch);
            Console.WriteLine("Query Syntax");
            foreach (IGrouping<string, Student> group in GroupByQS)
            {
                Console.WriteLine(group.Key + ": " + group.Count());
                foreach (var student in group)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}");
                }
            }
        }
        public static void GroupBy2()
        {
            //Using Method Syntax
            var GroupMS = Student.GetStudents()
                .GroupBy(x => x.Gender)
                .OrderByDescending(y => y.Key)
                .Select(std => new
                {
                    Key = std.Key,
                    Students = std.OrderBy(c => c.Name)
                });
            Console.WriteLine("Method Syntax");
            foreach (var group in GroupMS)
            {
                Console.WriteLine(group.Key + ":" + group.Students.Count());
                foreach (var student in group.Students)
                {
                    Console.WriteLine("Name: " + student.Name + ", Age: " + student.Age + ", Gender: " + student.Gender);
                }
            }

            //Using Query Syntax
            var GroupQS = (from std in Student.GetStudents()
                           group std by std.Gender into stdGroup
                           orderby stdGroup.Key descending
                           select new
                           {
                               Key = stdGroup.Key,
                               Students = stdGroup.OrderBy(c => c.Name)
                           });
            Console.WriteLine("\n\n\nQuery Syntax");
            foreach (var group in GroupQS)
            {
                Console.WriteLine(group.Key + ":" + group.Students.Count());
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch}");
                }
            }
        }
        public static void GroupBy3()
        {
            //Using Method Syntax
            var GroupByMS = Student.GetStudents()
                                   .GroupBy(s => s.Gender)
                                   .OrderByDescending(c => c.Key)
                                   .Select(std => new StudentGroup
                                   {
                                       Key = std.Key,
                                       Students = std.OrderBy(x => x.Name).ToList()
                                   });
            Console.WriteLine("Metod Syntax");
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + ": " + group.Students.Count());
                foreach (var student in group.Students)
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch}");
            }

            //Using Query Syntax
            var GroupByQS = (from std in Student.GetStudents()
                             group std by std.Gender into stdGroup
                             orderby stdGroup.Key descending
                             select new StudentGroup
                             {
                                 Key = stdGroup.Key,
                                 Students = stdGroup.OrderBy(x => x.Name).ToList()
                             });
            Console.WriteLine("Query Syntax");
            foreach (var group in GroupByQS)
            {
                Console.WriteLine(group.Key + ": " + group.Students.Count());
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, ID: {student.ID}");
                }
            }
        }
        public static void GroupByInto1()
        {
            //Using Query Syntax
            var GroupByIntoQS = (from std in Student.GetStudents()
                                 group std by new
                                 {
                                     std.Branch,
                                     std.Gender
                                 } into stdGroup
                                 select new
                                 {
                                     Branch = stdGroup.Key.Branch,
                                     Gender = stdGroup.Key.Gender,
                                     Students = stdGroup.OrderBy(x => x.Name)
                                 });
            Console.WriteLine("Query Syntax");
            foreach (var group in GroupByIntoQS)
            {
                Console.WriteLine($"Branch: {group.Branch}, Gender: {group.Gender}, No off Students = {group.Branch.Count()}");
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
                }
            }
        }
        public static void GroupByInto2()
        {
            //Using Method Syntax
            var GroupByIntoMS = Student.GetStudents()
                                       .GroupBy(x => new { x.Branch, x.Gender })
                                       .OrderByDescending(g => g.Key.Gender)
                                       .Select(g => new
                                       {
                                           Branch = g.Key.Branch,
                                           Gender = g.Key.Gender,
                                           Students = g.OrderBy(x => x.Name)
                                       }).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var group in GroupByIntoMS)
            {
                Console.WriteLine($"Branch: {group.Branch}, Gender: {group.Gender}, No of students = {group.Gender.Count()}");
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
                }
            }
            //Using Query Syntax
            var GroupByIntoQS = from student in Student.GetStudents()
                                group student by new
                                {
                                    student.Branch,
                                    student.Gender,
                                } into stdGroup
                                orderby stdGroup.Key.Branch descending,
                                stdGroup.Key.Gender ascending
                                select new
                                {
                                    Branch = stdGroup.Key.Branch,
                                    Gender = stdGroup.Key.Gender,
                                    Students = stdGroup.OrderBy(x => x.Name)
                                };
            Console.WriteLine("Query Syntax");
            foreach (var group in GroupByIntoQS)
            {
                Console.WriteLine($"Branch: {group.Branch}, Gender: {group.Gender}, No of students = {group.Gender.Count()}");
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
                }
            }
            Console.ReadKey();
        }
        public class StudentGroup
        {
            public string Key { get; set; }
            public List<Student> Students { get; set; }
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
}
