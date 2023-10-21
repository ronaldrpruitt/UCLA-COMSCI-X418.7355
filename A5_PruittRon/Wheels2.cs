namespace A5_PruittRon
{
    public class Wheels2 : Vehicle
    {
        public Wheels2(string companyName, string modelName, int productionYear, decimal salesPrice)
            : base(companyName, modelName, productionYear, salesPrice)
        {
        }

        public override string ToString()
        {
            return "This is a 2-wheel vehicle.\r\n";
        }
    }
}
