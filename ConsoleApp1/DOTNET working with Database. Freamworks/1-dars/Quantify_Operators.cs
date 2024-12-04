namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    internal class Quantify_Operators
    {
        public static void Start()
        {
            //All1();
            //All2();

            //Any1();
            Any2();
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
            Console.WriteLine("Barcha ismlar uzunligi 5 dan katta-mi? " + methodSyntax);

            //Using Query Syntax
            bool querySyntax = (from name in stringArray
                                select name).All(name => name.Length > 3);
            Console.WriteLine("Query Syntax");
            Console.WriteLine($"Barcha ismlar uzunligi 5 dan katta-mi? {querySyntax}");
        }
        public static void Any1()
        {
            int[] intArray = { 11, 15, 59, 35, 13, 56, 100 };

            //Using Method Syntax
            bool methodSyntax = intArray.Any(x => x < 10);
            Console.WriteLine("Method Syntax");
            Console.WriteLine("Massivda biror bir element 10 dan kichikmi? " + methodSyntax);

            //Using Query Syntax
            bool querySyntax = (from name in intArray
                                select name).Any(x => x < 10);
            Console.WriteLine("Query Syntax");
            Console.WriteLine("Masssivda biror bir element 10 dan kichikmi? " + querySyntax );
        }
        public static void Any2()
        {
            string[] stringArray = { "James", "Lochin", "Ruslan", "Allegri", "Sara" };

            //Using Method Syntax
            bool methodSyntax = stringArray.Any(name => name.Length > 5);
            Console.WriteLine("Method Syntax");
            Console.WriteLine($"Massiv ichida uzunligi 5 dan katta bo'lgan ismlar bormi? {methodSyntax}");

            //Using Query Syntax
            bool querySyntax = (from name in stringArray
                                select name).Any(name => name.Length > 3);
            Console.WriteLine("Query Syntax");
            Console.WriteLine("Massiv ichida uzunligi 5 dan katta bo'lgan ismlar bormi? " + querySyntax);
            Console.ReadKey();
        }
    }
}
