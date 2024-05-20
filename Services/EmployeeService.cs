using DependencyInversionAssignment.Interfaces;
using DependencyInversionAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionAssignment.Services
{
    public class EmployeeService
    {
        private readonly IDatabase _database;

        public EmployeeService(IDatabase database)
        {
            _database = database;
        }

        public void SaveEmployee(Employee employee)
        {
            _database.Save(employee);
        }
    }
}
