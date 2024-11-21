namespace ConsoleApp1._5_dars
{
    internal class Dayys
    {
        public DateTime Date { get; set; }
        public DaysOfWeek DayOfWeek { get; set; }
    }
    enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
