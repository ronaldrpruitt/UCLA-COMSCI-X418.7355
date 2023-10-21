using System;

namespace A5_PruittRon
{
    public abstract class Vehicle
    {
        private static int vehiclesCreated;
        private readonly string companyName;
        private readonly int inventoryId;
        private readonly string modelName;
        private readonly int productionYear;
        private readonly decimal salesPrice;
        private static readonly int tableWidth = 100;

        public Vehicle(string companyName, string modelName, int productionYear, decimal salesPrice)
        {
            this.companyName = companyName;
            this.modelName = modelName;
            this.productionYear = productionYear;
            this.salesPrice = salesPrice;
            vehiclesCreated++;
            inventoryId = vehiclesCreated;
        }

        public string CompanyName { get => companyName; }
        public int InventoryId { get => inventoryId; }
        public string ModelName { get => modelName; }
        public int ProductionYear { get => productionYear; }
        public decimal SalesPrice { get => salesPrice; }
        public int TotalVehiclesCreated { get => vehiclesCreated; }

        public void PrintRow(params string[] columns)
        {
            PrintLine();
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
            PrintLine();
        }

        private void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}