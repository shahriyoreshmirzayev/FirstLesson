namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class CustomSequence_Operators
    {
        public static void Start()
        {
            SequncesEqual();
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
        }
    }
}
