using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CreateVehicle_RonPruitt
{
    public class Vehicle
    {
        private static readonly List<Vehicle> vehiclesList = new List<Vehicle>();
        private readonly DateTime date;
        private string company;
        private bool isSold;
        private string model;
        private double salePrice;
        private string vin;
        private int year;

        public Vehicle() : this(null, null, 0, 0.00, "Illegal, check", false)
        {
            vehiclesList.Add(this);
        }

        public Vehicle(string company, string model, int year, double salePrice, string vin, bool isSold)
        {
            this.Company = company;
            this.model = model;
            Year = year;
            SalePrice = salePrice;
            Vin = vin;
            this.isSold = isSold;
            vehiclesList.Add(this);
        }

        public Vehicle(string company, string model, int year, double salePrice, string vin, bool isSold, DateTime dateTime)
        {
            this.Company = company;
            this.model = model;
            Year = year;
            SalePrice = salePrice;
            Vin = vin;
            this.isSold = isSold;
            this.date = dateTime;
            vehiclesList.Add(this);
        }

        public string Company { get => company; set => company = value; }

        public int GetVehiclesProcessedCount
        {
            get
            {
                return vehiclesList.Count;
            }
        }

        public bool IsSold { get => isSold; set => isSold = value; }
        public string Model { get => model; set => model = value; }

        public double SalePrice
        {
            get => salePrice;
            set
            {
                if (value > 0)
                {
                    salePrice = value;
                }
                else
                {
                    salePrice = 0.00;
                }
            }
        }

        public string Vin
        {
            get => vin;
            set
            {
                if (value.Length == 17 && isAlphaNumeric(value))
                {
                    vin = value;
                }
                else
                {
                    vin = "Illegal, check";
                }
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value > 1990 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    year = 0;
                }
            }
        }

        public string BuyVehicle()
        {
            this.isSold = true;
            Console.WriteLine("\r\n Vehicle Sold!");
            return ("Vehicle Sold!");
        }

        public void ClearVehicleList()
        {
            vehiclesList.Clear();
        }

        public void PrintCustomReport(DateTime date)
        {
            Console.WriteLine("\r\n************Custom Report************");
            var notSoldCarsUnder30 = vehiclesList.Where(v => v.isSold == false && (date - v.date).TotalDays < 30).OrderByDescending(v => v.date);
            var notSoldCarsUnder61 = vehiclesList.Where(v => v.isSold == false && (date - v.date).TotalDays < 62 && (date - v.date).TotalDays > 31).OrderByDescending(v => v.date);
            var notSoldCarsOver61 = vehiclesList.Where(v => v.isSold == false && (date - v.date).TotalDays > 62).OrderByDescending(v => v.date);
            var soldCars = vehiclesList.Where(v => v.isSold == true).OrderByDescending(v => v.isSold);

            Console.WriteLine("\n\rCars under 30 days on the lot not sold");
            Console.WriteLine("\n\r{0,-20} {1,-15} {2,-10} {3,-15} {4,-20} {5,-20} {6,-10}\n\r",
            "Car", "Model", "Year", "Sale Price", "Vin", "Date Received", "Sold");
            PrintLoop(notSoldCarsUnder30);
            Console.WriteLine($"Total: {notSoldCarsUnder30.Count()}\n\r");

            Console.WriteLine("\n\rCars over 31 - 61 days on the lot not sold");
            Console.WriteLine("\n\r{0,-20} {1,-15} {2,-10} {3,-15} {4,-20} {5,-20} {6,-10}\n\r",
            "Car", "Model", "Year", "Sale Price", "Vin", "Date Received", "Sold");
            PrintLoop(notSoldCarsUnder61);
            Console.WriteLine($"Total: {notSoldCarsUnder61.Count()}\n\r");

            Console.WriteLine("\n\rCars over 61 days on the lot not sold");
            Console.WriteLine("\n\r{0,-20} {1,-15} {2,-10} {3,-15} {4,-20} {5,-20} {6,-10}\n\r",
            "Car", "Model", "Year", "Sale Price", "Vin", "Date Received", "Sold");
            PrintLoop(notSoldCarsOver61);
            Console.WriteLine($"Total: {notSoldCarsOver61.Count()}\n\r");

            Console.WriteLine("\n\rCars Sold");
            Console.WriteLine("\n\r{0,-20} {1,-15} {2,-10} {3,-15} {4,-20} {5,-20} {6,-10}\n\r",
            "Car", "Model", "Year", "Sale Price", "Vin", "Date Received", "Sold");
            PrintLoop(soldCars);
            Console.WriteLine($"Total Sold: {soldCars.Count()}");
            Console.WriteLine("{0,0} {1,0:C3}", "Total Sales: ", soldCars.Sum(v => v.SalePrice));
        }

        public void PrintReport()
        {
            Console.WriteLine("\n\r{0,-20} {1,-15} {2,-10} {3,-15} {4,-20} {5,-10}\n\r",
                "Car", "Model", "Year", "Sale Price", "Vin", "Sold");

            foreach (var vehicle in vehiclesList)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        public override string ToString()
        {
            if (this.date == DateTime.MinValue)
            {
                return String.Format("{0,-20} {1,-15} {2,-10} {3,-15:C3} {4,-20} {5,-10}", this.company, this.model,
                this.year, this.SalePrice, this.vin, (this.isSold) ? "Yes" : "No");
            }
            else
            {
                return String.Format("{0,-20} {1,-15} {2,-10} {3,-15:C3} {4,-20} {5,-20} {6,-10}", this.company, this.model,
                this.year, this.SalePrice, this.vin, this.date.ToShortDateString(), (this.isSold) ? "Yes" : "No");
            }
        }

        private Boolean isAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(strToCheck);
        }

        private void PrintLoop(IOrderedEnumerable<Vehicle> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}