using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAssignment.Exceptions
{
     class AccidentException : Exception
    {
        public AccidentException(string message) : base(message)
        { 
        }

        public void HandleAccident()
        {
            Console.WriteLine("Airbags released");
            Console.WriteLine("Call the ambulance - 102");
        }
    }
}
