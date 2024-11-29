namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    public static class ProjectionOperators
    {
        public static void Start()
        {
            Where();
        }
        public static void Where()
        {
            List<int> intList = new List<int>() { 1, 15, 26, 5, 3, 4, 12, 30, 14, 24 };
            //Method Syntax
            IEnumerable<int> methodSyntax = intList.Where(x => x > 5);
            Console.WriteLine("Method Syntax");
            foreach (int i in methodSyntax)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            //Query Syntax
            IEnumerable<int> querySyntax = (from num in intList
                                            where num % 2 == 0
                                            select num).ToList();
            Console.WriteLine("Query Syntax");
            foreach(int i in querySyntax)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
