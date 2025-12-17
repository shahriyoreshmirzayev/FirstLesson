namespace ConsoleApp1;

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
