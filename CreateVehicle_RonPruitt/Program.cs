using System;
using System.Linq;

namespace CreateVehicle_RonPruitt
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create Test Vehicles
            VehicleTest.GenerateVehicleDataStandard();
            var test = VehicleTest.VehicleList.FirstOrDefault();

            //Print Report
            test.PrintReport();

            //Print Vehicle Processed Count
            int count = test.GetVehiclesProcessedCount;
            Console.WriteLine($"\n Vehicles Processed: {count}");

            //Buy Car
            test.BuyVehicle();
            test.PrintReport();

            //Bonus

            //Reset Data
            test.ClearVehicleList();
            VehicleTest.VehicleList.Clear();

            VehicleTest.GenerateVehicleDataWithData();
            test = VehicleTest.VehicleList.FirstOrDefault();
            test.PrintCustomReport(new DateTime(2018, 9, 30));
        }
    }
}