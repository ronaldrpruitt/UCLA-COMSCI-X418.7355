namespace A5_PruittRon
{
    public class Bicycle : Wheels2
    {
        private readonly bool hasAirPump;

        public Bicycle(string companyName, string modelName, int productionYear, decimal salesPrice, bool hasAirPump)
            : base(companyName, modelName, productionYear, salesPrice)
        {
            this.hasAirPump = hasAirPump;
        }

        public override string ToString()
        {
            PrintRow("InventoryId", "Bicycle", "Model", "Year", "Sale Price", "Air Pump");
            PrintRow(InventoryId.ToString(), CompanyName, ModelName, ProductionYear.ToString(), SalesPrice.ToString("C"), (this.hasAirPump) ? "Yes" : "No");
            return base.ToString();
        }
    }
}