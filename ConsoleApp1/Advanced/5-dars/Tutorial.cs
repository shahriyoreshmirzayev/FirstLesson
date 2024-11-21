namespace ConsoleApp1.Advanced._5_dars
{
    class Tutorial
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string[] Tags { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Description} - {Url} - {string.Join(", ", Tags)}";
        }
    }
}
