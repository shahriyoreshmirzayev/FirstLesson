namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Generation_Operators
    {
        public static void Start()
        {
            //Empty1();
            //Range();
            //Range1();
            //Range2();
            //Range3();
            //Repeat();
        }
        public static void Empty1()
        {
            IEnumerable<string> emtyCollection1 = Enumerable.Empty<string>();
            Console.WriteLine("Type: {0} " + emtyCollection1.GetType());
        }
        public static void Range()
        {
            IEnumerable<int> ints = Enumerable.Range(0, 100);
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
        public static void Range1()
        {
            //Method Syntax
            IEnumerable<int> number_ms = Enumerable.Range(0, 100).Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Method Syntax");
            foreach (int i in number_ms)
            {
                Console.Write(i + " ");
            }
            //Query Syntax
            IEnumerable<int> number_qs = (from num in Enumerable.Range(0, 100)
                                          where num % 2 == 1
                                          select num).ToList();
            Console.WriteLine("\nQuery Syntax");
            foreach (var item in number_qs)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
        public static void Range2()
        {
            //Method Syntax
            IEnumerable<int> number_ms = Enumerable.Range(1, 5).Select(x => x * x).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var item in number_ms)
            {
                Console.Write(item + " ");
            }
            //Query Syntax
            IEnumerable<int> number_qs = (from num in Enumerable.Range(1, 5)
                                          select num)
                                          .Select(x => x * x)
                                          .ToList();
            Console.WriteLine("\nQuery Syntax");
            foreach (var item in number_qs)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
        public static void Range3()
        {
            //Method Syntax
            IEnumerable<string> number_ms = Enumerable.Range(1, 5).Select(x => x + " Customlogic(x)");
            Console.WriteLine("Method Syntax");
            foreach (var item in number_ms)
            {
                Console.Write(item + " ");
            }
            //Query Syntax
            IEnumerable<string> number_qs = (from num in Enumerable.Range(1, 5)
                                             select num).
                                             Select(x => x + " Customlogic(x)").
                                             ToList();
            Console.WriteLine("\nQuery Syntax");
            foreach (var item in number_qs)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
        public static void Repeat()
        {
            //Method Syntax
            IEnumerable<string> string_ms = Enumerable.Repeat("C# .net developer is Shahriyor", 5).ToList();
            Console.WriteLine("Method Syntax");
            foreach (var item in string_ms)
            {
                Console.WriteLine(item);
            }
            //Query Syntax
            IEnumerable<string> string_qs = (from str in Enumerable.Repeat("C# .net developer is Azamat", 5)
                                             select str).ToList();
            Console.WriteLine("\nQuery Syntax");
            foreach (var item in string_qs)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        public static void Repeat1()
        {
            //Method Syntax
            IEnumerable<Student> string_ms = Enumerable.Repeat(new Student() { Name = "Shahariyor", ID = 12 }, 12);
            Console.WriteLine("Method Syntax");
            foreach (var item in string_ms)
            {
                Console.WriteLine($"Name: {item.Name}, ID = {item.ID}");
            }
            Console.Read();
        }
    }
}
