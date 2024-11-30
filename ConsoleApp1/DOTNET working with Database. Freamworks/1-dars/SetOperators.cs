namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    internal class SetOperators
    {
        public static void Start()
        {
            Distinct1();
        }
        public static void Distinct1()
        {
            List<int> intList = new List<int>()
            {
                1,2,2,2,3,3,3,3,3,4,5,5,5,6,6,6,6,6,7,7,7,8,8,9
            };
            //Query Syntax
            var querySyntax = (from number in intList
                               select number).Distinct();
            Console.WriteLine("Query Syntax");
            foreach (var number in querySyntax)
            {
                Console.Write($"{number} ");
            }
            //Method Syntax
            var methodSyntax = intList.Distinct();
            Console.WriteLine("\nMethod Syntax");
            foreach (var number in methodSyntax)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
