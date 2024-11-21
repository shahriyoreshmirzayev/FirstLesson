namespace ConsoleApp1._1_dars
{
    internal class MyDatee
    {
        public int _days;
        public int _month;
        public int _year;
        public void PrintDate()
        {
            Console.WriteLine($"{_days:D2}:{_month:D2}:{_year}");
        }
    }
}
