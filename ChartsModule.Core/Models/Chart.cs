namespace ChartsModule.Core.Models
{
    /// <summary>
    /// Chart data.
    /// </summary>
    /// <remarks>
    /// A chart can be storaged with more than one bar interval.
    /// </remarks>
    public class Chart
    {
        /// <summary>
        /// A name of a pair is two currency codes joined with a dash.
        /// </summary>
        /// <example>
        /// <see cref="Name"/> = "BTC-USTD";
        /// </example>
        public string? Name { get; set; }

        public TimeOnly TimeStart { get; set; }

        public string? Interval { get; set; }

        /// <summary>
        /// The trade volume in USDT.
        /// </summary>
        public decimal? Volume24h { get; set; }

        public Bar[]? Bars { get; set; }
    }
}
