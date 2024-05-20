using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionAssignment.Models
{
    public class Employee
    {
        private string Name;
        private string Address;

        public Employee(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetAddress()
        {
            return Address;
        }
    }
}