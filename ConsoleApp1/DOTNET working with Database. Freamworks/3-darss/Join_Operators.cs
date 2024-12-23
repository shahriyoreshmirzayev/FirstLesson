namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._3_darss
{
    public class Join_Operators
    {
        public static void Start()
        {
            //InnerJoinMethodSyntax();
            //InnerJoinQuerySyntax();
            //InnerJoinMethodSyntax1();
            JoinMultibleDatabaseQS();


        }
        public static void JoinMultibleDatabaseQS()
        {
            var ResultQS = (from emp in Employee.GetEmployes()
                            join adrs in Address.GetAddresses()
                            on emp.AddressID equals adrs.ID

                            join dept in Department.GetDepartments()
                            on emp.DepartmentID equals dept.ID

                            select new
                            {
                                ID = emp.ID,
                                EmployeeName = emp.Name,
                                DepartmentName = dept.Name,
                                AddressLine = adrs.AddressLine,
                            }).ToList();

            Console.WriteLine("Query Syntax");
            foreach (var item in ResultQS)
            {
                Console.WriteLine($"Name: {item.EmployeeName}");
            }
        }
        public static void InnerJoinMethodSyntax1()
        {
            var ResultMS = Employee.GetEmployes()
                           .Join(Address.GetAddresses(),
                           employee => employee.AddressID,
                           address => address.ID,
                           (employee, address) => new
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine,
                           }).ToList();

            // Natijani chiqarish
            ResultMS.ForEach(employee => Console.WriteLine($"Name: {employee.EmployeeName}, Address: {employee.AddressLine}"));

            Console.ReadKey();
        }

        public static void InnerJoinMethodSyntax()
        {
            var ResultMS = Employee.GetEmployes()
                           .Join(Address.GetAddresses(),
                           employee => employee.AddressID,
                           address => address.ID,
                           (employee, address) => new
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine,
                           }).ToList();

            ResultMS.ForEach(employee => Console.WriteLine($"Name: {employee.EmployeeName}, Address: {employee.AddressLine}"));
            foreach (var item in ResultMS)
            {
                Console.WriteLine($"Name: {item.EmployeeName}, Address: {item.AddressLine}");
            }
            Console.ReadKey();
        }
        public static void InnerJoinQuerySyntax()
        {
            var ResultQS = (from emp in Employee.GetEmployes()
                            join address in Address.GetAddresses()
                            on emp.AddressID equals address.ID
                            select new
                            {
                                EmployeeName = emp.Name,
                                AddressLine = address.AddressLine,
                            });
            foreach (var item in ResultQS)
            {
                Console.WriteLine($"Name: {item.EmployeeName}, Address: {item.AddressLine}");
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressID { get; set; }
        public int DepartmentID { get; set; }
        public static List<Employee> GetEmployes()
        {
            return new List<Employee>()
        {
            new Employee() { ID = 1, Name = "Maftuna", AddressID = 101, DepartmentID = 1 },
            new Employee() { ID = 2, Name = "Asad", AddressID = 110, DepartmentID = 2 },
            new Employee() { ID = 3, Name = "Zilola", AddressID = 102, DepartmentID = 2 },
            new Employee() { ID = 4, Name = "Dilnoza", AddressID = 103, DepartmentID = 1 },
            new Employee() { ID = 5, Name = "Fotima", AddressID = 104, DepartmentID = 2 },
            new Employee() { ID = 6, Name = "Hilola", AddressID = 105, DepartmentID = 2 },
            new Employee() { ID = 7, Name = "Saidakbar", AddressID = 106, DepartmentID = 3 },
            new Employee() { ID = 8, Name = "Jo'rka", AddressID = 107, DepartmentID = 3 },
            new Employee() { ID = 9, Name = "Javlon", AddressID = 108, DepartmentID = 1 },
            new Employee() { ID = 10, Name = "Kamron", AddressID = 109, DepartmentID = 2 }
        };
        }
    }
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<Address> GetAddresses()
        {
            return new List<Address>()
        {
            new Address() { ID = 1, AddressLine = "AddressLine1" },
            new Address() { ID = 2, AddressLine = "AddressLine2" },
            new Address() { ID = 3, AddressLine = "AddressLine3" },
            new Address() { ID = 4, AddressLine = "AddressLine4" },
            new Address() { ID = 5, AddressLine = "AddressLine5" },
            new Address() { ID = 6, AddressLine = "AddressLine6" },
            new Address() { ID = 7, AddressLine = "AddressLine7" },
            new Address() { ID = 8, AddressLine = "AddressLine8" },
            new Address() { ID = 9, AddressLine = "AddressLine9" },
            new Address() { ID = 10, AddressLine = "AddressLine10" }
        };
        }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetDepartments()
        {
            return new List<Department>()
            {
            new Department() { ID = 1, Name = "IT" },
            new Department() { ID = 2, Name = "HR" },
            new Department() { ID = 3, Name = "Teamlead" },
            new Department() { ID = 4, Name = "Security" }
            };
        }
    }
}
