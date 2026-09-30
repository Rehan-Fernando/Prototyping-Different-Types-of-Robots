using System;
using System.Collections.Generic;
using System.Text;

namespace _30thOfSep
{
    public class  IndustrialRobot : IRobot
    {

        public String ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }
        public string IndustrialTask { get; set; }

        public IRobot Clone()
        {
            return (IndustrialRobot)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Model Name: {ModelName}");
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} mAh");
            Console.WriteLine($"Software Version: {SoftwareVersion}");
            Console.WriteLine($"Industrial Task: {IndustrialTask}");
        }
    }
}
