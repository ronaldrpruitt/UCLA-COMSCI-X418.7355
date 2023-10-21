using System;

namespace A5_PruittRon
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleTest.GenerateVehicles();

            foreach (var vehicle in VehicleTest.VehicleList)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
