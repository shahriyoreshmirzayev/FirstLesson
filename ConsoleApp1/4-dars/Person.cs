namespace ConsoleApp1;

internal class Person
{
    public string _name { get; set; }
    public string _adress { get; set; }
    public string haircolor { get; set; }
    public string eyecolor { get; set; }

    public void setName(string name)
    {
        _name = name;
    }
    public void newAdress(string adress)
    {
        _adress = adress;
    }
}
