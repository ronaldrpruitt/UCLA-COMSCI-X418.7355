using System;
using System.Collections.Generic;

namespace CreateVehicle_RonPruitt
{
    static class VehicleTest
    {
        public static List<Vehicle> VehicleList = new List<Vehicle>();
        public static void GenerateVehicleDataStandard()
        {
            VehicleList.Add(new Vehicle("Aston Martin", "Vantag", 2012, 59000.00, "SA007678901234567", false));
            VehicleList.Add(new Vehicle("Chevrolet", "Malibu", 2009, 5995.00, "V2345678901234567", false));
            VehicleList.Add(new Vehicle("Chevrolet", "Camaro", 2011, 19000.00, "V123X03456J201344", false));
            VehicleList.Add(new Vehicle("Chevrolet", "Camaro", 2015, 30888.00, "JKL3456789001234", false));
            VehicleList.Add(new Vehicle("Chevrolet", "Corvette", 2016, 71995.00, "AJ234567876L12345", false));
            VehicleList.Add(new Vehicle("Chevrolet", "Corvette", 1973, 11000.00, "H1234T65432456789", false));
            VehicleList.Add(new Vehicle("Ford", "Model A", 1930, 9000, "No Vin number", false));
            VehicleList.Add(new Vehicle("Ford", "F-150 Raptor", 2012, -89000, "R456789LWQ2345678", false));
            VehicleList.Add(new Vehicle("Toyota", "Camry", 2018, 22560, "T0234566789LA1234", false));
            VehicleList.Add(new Vehicle("Toyota", "Solara", 2005, 7000, "L2345B78901234567", false));
        }

        public static void GenerateVehicleDataWithData()
        {
            VehicleList.Add(new Vehicle("BMW", "M6", 2018, 136615, "V0070123345443222", false, new DateTime(2018, 9, 03)));
            VehicleList.Add(new Vehicle("BMW", "2 Series", 2018, 56370, "L5600454332346789", true, new DateTime(2018, 8, 23)));
            VehicleList.Add(new Vehicle("BMW", "X5", 2018, 64535, "K8765563783211234", false, new DateTime(2018, 7, 12)));
            VehicleList.Add(new Vehicle("Chevrolet", "Impala", 2018, 22980, "A9876543443234544", false, new DateTime(2018, 7, 21)));
            VehicleList.Add(new Vehicle("Chevrolet", "Impala", 2018, 21760, "J7766554347877765", false, new DateTime(2018, 8, 3)));
            VehicleList.Add(new Vehicle("Chevrolet", "Spark", 2018, 14888, "J2234567765554433", false, new DateTime(2018, 6, 23)));
            VehicleList.Add(new Vehicle("Mercedes-Benz", "S 550", 2014, 52345, "U567876L123459876", false, new DateTime(2018, 7, 25)));
            VehicleList.Add(new Vehicle("Mercedes-Benz", "E 300 Sport", 2019, 57456, "H345LT78634567542", true, new DateTime(2018, 9, 1)));
        }
    }
}
