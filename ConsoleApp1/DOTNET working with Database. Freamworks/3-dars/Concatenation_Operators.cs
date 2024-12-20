namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_dars
{
    internal class Concatenation_Operators
    {
        public static void Start()
        {
            Concat1();
        }
        public static void Concat1()
        {
            List<int> sequnce1 = new List<int>() { 1, 2, 3, 4 };
            List<int> sequnce2 = new List<int>() { 2, 3, 5, 6 };

            //Method Syntax
            var MS = sequnce1.Concat(sequnce2).ToList();
            //Using Query Syntax
            var QS = (from num in sequnce1
                     select num).Concat(sequnce2).ToList();
            foreach (int num in MS )
            {
                Console.Write(num + " ");
            }
            Console.Read();
        }
    }
}
