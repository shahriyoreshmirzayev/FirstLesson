namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    public class Conversion_Operators
    {
        public static void Start()
        {
            //ToArray();
            //ToList();
            ToDictionary();
        }
        public static void ToArray()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //Method Syntax
            int[] new_numbers = numbers.Where(x => x > 3).ToArray();
            Console.WriteLine("Method Syntax");
            foreach (int number in new_numbers)
            {
                Console.Write(number + " ");
            }
            //Query Syntax
            Console.WriteLine("\nQuery Syntax");
            var querySyntax = (from num in numbers
                               where num > 3
                               select num).ToArray();
            foreach (int number in querySyntax)
            {
                Console.Write(number + " ");
            }
            Console.Read();
        }
        public static void ToList()
        {
            List<string> names = new List<string>() { "Ghost", "Enzo", "rv", "Mike Tyson", "Abdulloh", "Anvar", "Diyor", "Jony" };
            List<string> short_name = names.Where(name => name.Length < 5).ToList();
            short_name.ForEach(f => Console.Write($"{f} "));
            Console.Read();
        }
        public static void ToDictionary()
        {
            string[] counntries = { "France", "Germany", "Italy", "Spain", "United Kingdom", "Germany" };
            Dictionary<string, int> countryLength = counntries.ToDictionary(c => c, c => c.Length);
            foreach (KeyValuePair<string, int> pair in countryLength)
            {
                Console.WriteLine("Counrty {0},Lenght {1}" , pair.Key , pair.Value);
            }
            Console.Read();
        }
    }
}
