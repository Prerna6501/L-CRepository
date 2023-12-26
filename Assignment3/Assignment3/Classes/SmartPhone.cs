using Assignment3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Classes
{
    public class SmartPhone : IDevice
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Smartphone: Model X, RAM: 8GB, Storage: 128GB");
        }
    }
}
