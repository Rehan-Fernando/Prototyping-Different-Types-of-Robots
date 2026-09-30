namespace _30thOfSep
{
     internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot servicePrototype = new ServiceRobot
            {
                ModelName = "ServiceBot-3000",
                BatteryCapacity = 5000,
                SoftwareVersion = "v1.2.3",
                ServiceTask = "Cleaning"
            };

            ServiceRobot serviceRobot2 = (ServiceRobot)servicePrototype.Clone();

            serviceRobot2.BatteryCapacity = 6000;   

            serviceRobot2.SoftwareVersion = "v1.3.0";

            Console.WriteLine("Original Service Robot:");
            servicePrototype.Display();

            Console.WriteLine("Cloned and Customized Robot:");
            serviceRobot2.Display();

            IndustrialRobot industrialPrototype = new IndustrialRobot
            {
                ModelName = "IndustroBot-5000",
                BatteryCapacity = 8000,
                SoftwareVersion = "v2.1.0",
                IndustrialTask = "Welding"
            };

            IndustrialRobot industrialRobot2 = (IndustrialRobot)industrialPrototype.Clone();

            industrialRobot2.BatteryCapacity = 9000;

            industrialRobot2.IndustrialTask = "Painting";

            Console.WriteLine("Industrial Cloned Robot:");
            industrialRobot2.Display();



            EntertainmentRobot entertainmentPrototype = new EntertainmentRobot 
            {
                ModelName = "EntertainoBot-2000",
                BatteryCapacity = 4000,
                SoftwareVersion = "v3.0.1",
                EntertainmentTask = "Dancing"
            };

            EntertainmentRobot entertainmentRobot2 = (EntertainmentRobot)entertainmentPrototype.Clone();

            entertainmentRobot2.BatteryCapacity = 4500;
            entertainmentRobot2.EntertainmentTask = "Singing";

            Console.WriteLine("Entertainment Cloned Robot:");
            entertainmentRobot2.Display();

        }
    }
}
