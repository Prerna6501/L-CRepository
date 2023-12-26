using Assignment3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Classes
{
    public class ClientWithFactory
    {
        static void Main(string[] args)
        {
            IDeviceFactory smartphoneFactory = new SmartPhoneFactory();
            IDeviceFactory laptopFactory = new LaptopFactory();

            IDevice smartphone = smartphoneFactory.CreateDevice();
            IDevice laptop = laptopFactory.CreateDevice();

            smartphone.DisplayDetails();
            laptop.DisplayDetails();
        }
    }
}
