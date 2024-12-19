namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Element_Operators
    {
        public static void Start()
        {
            //ElementAt();
            //ElementAt2();
            //First();
            Last();
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
            //Default qiymay qaytarmydi 
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Method Syntax
            var ResultMS = numbers.ElementAtOrDefault(56);
            //Query Syntax
            var ResultQS = (from num in numbers
                            select num)
                            .ElementAtOrDefault
                            (56);
            Console.WriteLine(ResultQS);
            Console.Read();
        }
        public static void First()
        {
            //bu method birinchi uchragan elementni qaytaradi
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Using Query Syntax
            var ResultQS = (from num in numbers
                            select num).First(num => num == 5);
            Console.WriteLine(ResultQS);

            //Using Method Syntax
            var ResultMS = numbers.FirstOrDefault(number => number == 5);
            Console.WriteLine(ResultMS);
        }
        public static void Last()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 };
            //Using Query Syntax
            var ResultQS = (from num in numbers
                           select num).Last(num => num == 5);

            //Using Method Syntax
            var ResultMS = numbers.LastOrDefault(number => number == 65);
            Console.WriteLine("Method Syntax: " + ResultMS);
            Console.WriteLine("Query Syntax: " + ResultQS);
        }
    }
}
