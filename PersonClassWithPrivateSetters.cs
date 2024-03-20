using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetterAssignment
{
    public class PersonClassWithPrivateSetters
    {
        public string Name { get;  }
        public int Age { get; }
        public PersonClassWithPrivateSetters(string name , int age)
        {
            Name = name;
            Age = age;
        }
    }
}
