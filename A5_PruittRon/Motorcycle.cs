namespace A5_PruittRon
{
    public class Motorcycle : Wheels2
    {
        private readonly bool useOffRoad;

        public Motorcycle(string companyName, string modelName, int productionYear, decimal salesPrice, bool useOffRoad)
            : base(companyName, modelName, productionYear, salesPrice)
        {
            this.useOffRoad = useOffRoad;
        }

        public override string ToString()
        {
            PrintRow("InventoryId", "Motorcycle", "Model", "Year", "Sale Price", "Off Road");
            PrintRow(InventoryId.ToString(), CompanyName, ModelName, ProductionYear.ToString(), SalesPrice.ToString("C"), (this.useOffRoad) ? "Yes" : "No");
            return base.ToString();
        }
    }
}