using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAssignment.Exceptions
{
     class OutOfFuelException : Exception
    {
        public OutOfFuelException(string message) : base(message)
        {
        }
        public void HandleOutOfFuelException()
        {
            Console.WriteLine("Fill the fuel asap!!!!!");
        }
    }
}
