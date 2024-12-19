namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Element_Operators
    {
        public static void Start()
        {
            //ElementAt();
            ElementAt2();
        }
        public static void ElementAt()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Using Method Syntax
            var ResultMS = numbers.ElementAt(4);

            //Using Method Syntax
            var ResultQS = (from num in numbers
                            select num).
                            ElementAt(4);
            Console.WriteLine("Method Syntax: " + ResultMS);
            Console.WriteLine("Query Syntax: " + ResultQS);
            
        }
        public static void ElementAt2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Method Syntax
            var ResultMS = numbers.ElementAtOrDefault(56);
            //Query Syntax
            var ResultQS = (from num in numbers
                            select num)
                            .ElementAtOrDefault
                            (56);
            Console.WriteLine(ResultQS);
        }
    }
}
