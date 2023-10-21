namespace GatesCandyStore_PruittRon
{
    public class Order
    {
        public string Name { get; set; }

        public Candy CandyItem { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public OrderStatus Status {get; set;}

        public decimal Total { get { return Quantity * Price; } }

    }
}
