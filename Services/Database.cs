using DependencyInversionAssignment.Interfaces;
using DependencyInversionAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionAssignment.Services
{
    public class Database : IDatabase
    {
        public void Save(Employee employee)
        {
            Console.WriteLine($"Saving data for Employee{employee.GetName()}");
            Console.WriteLine("Saved....");
        }
    }
}
