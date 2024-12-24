namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class CustomSequence_Operators
    {
        public static void Start()
        {
            //SequncesEqual();
            //SequncesEqual1();
            //SequncesEqualWithReferences();
            //SequncesEqualWithReferences1();
        }
        public static void SequncesEqual()
        { 
            List<string> list1 = new List<string>() { "Paris", "Dubai", "Hyderabad" };
            List<string> list2 = new List<string>() { "Paris", "Dubai", "Hyderabad" };

            //Using Method Syntax
            bool ResultMS = list1.SequenceEqual(list2);
            Console.WriteLine("Method Syntax: " + ResultMS);

            //Using Query Syntax
            bool ResultQS = (from emp in list1
                             select emp).SequenceEqual(list2);
            Console.WriteLine("Query Syntax: " + ResultQS);
            Console.ReadKey();
        }
        public static void SequncesEqual1()
        {
            List<string> list1 = new List<string> { "One", "Two", "Three", "Four", "Five", "Six" };
            List<string> list2 = new List<string> { "Two", "One", "Three", "Four", "Five", "Six" };

            //Using Method Syntax
            bool result = list1.SequenceEqual(list2);
            Console.WriteLine("Method Syntax: " + result);

            //Using Query Syntax
            bool resultQS = (from emp in list1
                            select emp).
                            SequenceEqual(list2);
            Console.WriteLine($"Query Syntax: {resultQS}");
            Console.ReadKey();
        }
        public static void SequncesEqualWithReferences()
        {
            Student student = new Student() { ID = 1, Name = "Joe" };
            IList<Student> students1 = new List<Student>() { student };
            IList<Student> students2 = new List<Student>() { student };
            bool isEQual = students1.SequenceEqual(students2);
            Console.WriteLine(isEQual);
            Console.ReadKey();
        }
        public static void SequncesEqualWithReferences1()
        {
            Student student1 = new Student() { ID = 1, Name = "Joe" };
            Student student2 = new Student() { ID = 1, Name = "Joe" };

            IList<Student> students1 = new List<Student>() { student1 };
            IList<Student> students2 = new List<Student>() { student2 };

            //Using Method Syntax
            bool ResultMS = students1.SequenceEqual(students2);
            Console.WriteLine("Method Syntax: " + ResultMS);

            //Using Query Syntax
            bool ResultQS = (from emp in students1
                             select emp).SequenceEqual(students2);
            Console.WriteLine($"Query Syntax: {ResultQS}");
            Console.ReadKey();
        }
    }
}
