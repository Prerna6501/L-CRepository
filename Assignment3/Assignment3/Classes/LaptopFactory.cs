using Assignment3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Classes
{
    public class LaptopFactory : IDeviceFactory
    {
        public IDevice CreateDevice()
        {
            return new Laptop();
        }
    }
}
