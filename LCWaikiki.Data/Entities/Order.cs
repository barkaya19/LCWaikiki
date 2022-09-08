namespace LCWaikiki.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string DispatchPoint { get; set; }
        public string Receiver { get; set; }
        public string ContactPhone { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
