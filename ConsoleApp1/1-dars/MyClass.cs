namespace ConsoleApp1._1_dars
{
    internal class MyClass
    {
        public int First;
        public int Second;
        public void AboutFields()
        {
            Console.WriteLine($"Ikkita sonni qiymati ==> {First} : {Second}");
        }
        public int SumOfFields()
        {
            return First + Second;
        }
        public int MaxOfFields()
        {
            return First > Second ? First : Second;
        }
    }
}
