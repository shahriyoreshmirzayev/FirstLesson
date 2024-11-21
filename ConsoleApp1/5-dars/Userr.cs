namespace ConsoleApp1._5_dars
{
    internal class Userr
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
    }
    enum Gender
    {
        Male,
        Female
    }
}
