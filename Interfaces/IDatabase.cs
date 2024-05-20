using DependencyInversionAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionAssignment.Interfaces
{
    public interface IDatabase
    {
        void Save(Employee employee);
    }
}
