using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{
    public class Laptop
    {
        public string Brand { get; set; }   
        public bool IsConnected { get; private set; }
        public int BatteryPercentage { get; private set; }

        public Laptop(string brand) 
        {
            Brand = brand;
            IsConnected = false;
            BatteryPercentage = 0;
        }

        public bool Connect()
        {
            IsConnected = true;
            return IsConnected;
        }

        public void Charge(int minutes)
        {
            BatteryPercentage += minutes / 10;
            if (BatteryPercentage > 100)
            {
                BatteryPercentage = 100;
            }
        }

        public string Display()
        {
            return $"Smartphone: {Brand}, Battery Percentage: {BatteryPercentage}%";
        }
    }
}
