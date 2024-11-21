namespace ConsoleApp1._3_dars
{
    internal class Personn
    {
        public string Name { get; set; }
        public int  Age { get; set; }
        public string Nationality { get; set; }
        public string PassportCode { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nNationality: {Nationality}\nPassport Code: {PassportCode}";
        }
    }
}
