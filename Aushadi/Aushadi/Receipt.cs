namespace Aushadi
{
    public class Receipt
    {
        public int ID { get; set; }
        public string productName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Selection { get; set; }
        public string Total { get { return (Price * Quantity).ToString(); } }
    }
}
