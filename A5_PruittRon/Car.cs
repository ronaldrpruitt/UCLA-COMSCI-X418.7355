namespace A5_PruittRon
{
    public class Car : Wheels4
    {
        private readonly int maximumNumberOfPassengers;

        public Car(string companyName, string modelName, int productionYear, decimal salesPrice, int maximumNumberOfPassengers)
            : base(companyName, modelName, productionYear, salesPrice)
        {
            this.maximumNumberOfPassengers = maximumNumberOfPassengers;
        }

        public override string ToString()
        {
            PrintRow("InventoryId", "Car", "Model", "Year", "Sale Price", "Passengers");
            PrintRow(InventoryId.ToString(), CompanyName, ModelName, ProductionYear.ToString(), SalesPrice.ToString("C"), maximumNumberOfPassengers.ToString());
            return base.ToString();
        }
    }
}