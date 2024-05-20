using DependencyInversionAssignment.Interfaces;
using DependencyInversionAssignment.Models;
using DependencyInversionAssignment.Services;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        IDatabase database = new Database();
        EmployeeService employeeService = new EmployeeService(database);
       
        Console.WriteLine("Enter employee name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter employee address:");
        string address = Console.ReadLine();
       
        Employee employee = new Employee(name , address);
        employeeService.SaveEmployee(employee);
    }
}
