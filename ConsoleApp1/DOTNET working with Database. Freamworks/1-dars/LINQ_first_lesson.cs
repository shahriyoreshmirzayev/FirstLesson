﻿namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars
{
    public static class LINQ_first_lesson
    {
        public static void Start()
        {
            Select();
        }
        public static void Select()
        {
            //Using Query Syntax
            List<int> basicPropQuery = (from emp in Employee.GetEmployees()
                                        select emp.ID).ToList();
            Console.WriteLine("Query Syntax");
            foreach (var id in basicPropQuery)
            {
                Console.WriteLine($"ID: {id}");
            }

            IEnumerable<int> basicPropMethod = Employee.GetEmployees()
                .Select(emp => emp.ID);
            Console.WriteLine("Method Syntax");
            foreach (var id in basicPropMethod)
            {
                Console.WriteLine($"ID: {id}");
            }
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double Salary { get; set; }
        public List<string> Programming { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new()
            {
                new() {ID = 101, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 300000, Programming = new List<string> {"C++", "C#", "Python" } },
                new() {ID = 102, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 300000, Programming = new List<string> {"C++", "C#", "Python"}},
                new() {ID = 103, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 300000, Programming = new List<string> {"C++", "C#", "Python"}},
                new() {ID = 104, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 300000, Programming = new List<string> {"C++", "C#", "Python"}},
                new() {ID = 105, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 300000, Programming = new List<string> {"C++", "C#", "Python"}},
                new() {ID = 106, FirstName = "Dilshod", LastName = "Dilshodov", Salary = 300000, Programming = new List<string> {"C++", "C#", "Python"} }
                };
            return employees;

        }
    }
}

