namespace A5_PruittRon
{
    public class Truck : Wheels4
    {
        private readonly int maxLoadCapacity;

        public Truck(string companyName, string modelName, int productionYear, decimal salesPrice, int maxLoadCapacity)
            : base(companyName, modelName, productionYear, salesPrice)
        {
            this.maxLoadCapacity = maxLoadCapacity;
        }

        public override string ToString()
        {
            PrintRow("InventoryId", "Truck", "Model", "Year", "Sale Price", "Max Load Lbs");
            PrintRow(InventoryId.ToString(), CompanyName, ModelName, ProductionYear.ToString(), SalesPrice.ToString("C"), maxLoadCapacity.ToString());
            return base.ToString();
        }
    }
}