namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    internal class Quantify_Operators
    {
        public static void Start()
        {
            //All1();
            All2();
        }
        public static void All1()
        {
            int[] massiv = new int[] { 14, 19, 13, 11, 21, 45, 3, 12, 7 };

            //Using Method Syntax
            bool methodSyntax = massiv.All(x => x > 2);
            Console.WriteLine("Method Syntax");
            Console.WriteLine($"Massivdagi barcha elementlar 10 sonidan katta-mi?: {methodSyntax}");

            //Using Method Syntax
            bool querySyntax = (from x in massiv
                                select x).All(x => x > 2);
            Console.WriteLine("Query Syntax");
            Console.WriteLine("Massivdagi barcha elementlar 2 sonidan katta-mi?: " + querySyntax);
        }
        public static void All2()
        {
            string[] stringArray = { "James", "Lochin", "Ruslan", "Allegri", "Sara" };

            //Using Method Syntax
            bool methodSyntax = stringArray.All(name => name.Length > 5);
            Console.WriteLine("Method Syntax");
            Console.WriteLine("Batcha ismlar uzunligi 5 dan katta-mi? " + methodSyntax);

            //Using Query Syntax
            bool querySyntax = (from name in stringArray
                                select name).All(name => name.Length > 3);
            Console.WriteLine("Query Syntax");
            Console.WriteLine($"Barcha ismlar uzunligi 5 dan katta-mi? {querySyntax}");
        }
    }
}
