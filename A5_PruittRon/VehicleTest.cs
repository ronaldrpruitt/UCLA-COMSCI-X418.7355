using System.Collections.Generic;

namespace A5_PruittRon
{
    internal static class VehicleTest
    {
        public static List<Vehicle> VehicleList = new List<Vehicle>();

        public static void GenerateVehicles()
        {
            VehicleList.Add(new Car("BMW", "M6", 2020, 50661, 4));
            VehicleList.Add(new Car("Chevrolet", "Impala", 2019, 18615, 5));
            VehicleList.Add(new Car("Mercedes-Benz", "S 550", 2018, 60615, 4));

            VehicleList.Add(new Truck("Ford", "F-150", 2019, 46615, 5000));
            VehicleList.Add(new Truck("Ford", "Ranger", 2019, 26615, 2500));
            VehicleList.Add(new Truck("Ford", "F-350", 2019, 66615, 10000));

            VehicleList.Add(new Bicycle("Surly", "SteamRoller", 2019, 1200, false));
            VehicleList.Add(new Bicycle("Surly", "Cross Check", 2019, 2200, true));
            VehicleList.Add(new Bicycle("Surly", "karate monkey", 2019, 3000, true));

            VehicleList.Add(new Motorcycle("Triumph", "Speed Triple", 2019, 15000, false));
            VehicleList.Add(new Motorcycle("Triumph", "Bobber", 2019, 17000, false));
            VehicleList.Add(new Motorcycle("Triumph", "Tiger 900", 2019, 12000, true));
        }
    }
}