namespace ConsoleApp1;

internal class EmployeeSerialization
{
    public string Name;
    public int Id { get; set; }
    public string MyProperty { get; set; }
    public string EmployeeDepartment { get; set; }
    public override string ToString()
    {
        return $"Name: {Name}, ID: {Id}, Property: {MyProperty}, Employee Department: {EmployeeDepartment}";
    }
}
