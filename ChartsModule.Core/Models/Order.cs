namespace ChartsModule.Core.Models
{
    /// <summary>
    /// Appears when an order is executed, contains executed trade data.
    /// </summary>
    public class Order
    {
        public string? Pair { get; set; }

        public decimal? Price { get; set; }

        public decimal? Amount { get; set; }

        public TimeOnly? Time { get; set; }
    }
}
