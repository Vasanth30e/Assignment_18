using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{
    public class Smartphone
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryPercentage { get; private set; }

        public Smartphone(string model)
        {
            Model = model;
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
            BatteryPercentage += minutes / 5;
            if(BatteryPercentage > 100)
            {
                BatteryPercentage = 100;             
            }
            
        }

        public string Display() 
        {
            return $"Smartphone: {Model}, Battery Percentage: {BatteryPercentage}%";
        }
    }
}
