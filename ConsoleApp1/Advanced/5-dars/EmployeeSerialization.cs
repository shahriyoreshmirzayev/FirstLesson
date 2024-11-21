namespace ConsoleApp1.Advanced._5_dars
{
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
}
