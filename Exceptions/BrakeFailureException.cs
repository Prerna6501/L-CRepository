using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingAssignment.Exceptions
{
     class BrakeFailureException : Exception
    {
        public BrakeFailureException(string message) : base(message)
        {
        
        }

        public void HandleBrakeFailure() 
        {
            Console.WriteLine("Pull into low gear and find a safe place to pull over");
        }
    }
}
