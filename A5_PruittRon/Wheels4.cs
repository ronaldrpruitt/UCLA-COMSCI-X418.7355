namespace A5_PruittRon
{
    public class Wheels4 : Vehicle
    {
        public Wheels4(string companyName, string modelName, int productionYear, decimal salesPrice)
            : base(companyName, modelName, productionYear, salesPrice)
        {
        }

        public override string ToString()
        {
            return "This is a 4-wheel vehicle.\r\n";
        }
    }
}
