namespace ChartsModule.Core.Models
{
    /// <summary>
    /// Contains pair data.
    /// </summary>
    /// <remarks>
    /// One pair relates to one chart.
    /// </remarks>
    public class Pair
    {
        /// <summary>
        /// A name of a pair is two currency codes joined with a dash.
        /// </summary>
        /// <example>
        /// <see cref="Name"/> = "BTC-USDT";
        /// </example>
        public string? Name { get; set; }

        public int PrecisionPrice { get; set; }

        public int PrecisionAmount { get; set; }

        /// <summary>
        /// Bar intervals that user can request.
        /// </summary>
        /// <remarks>
        /// If a bar with that interval isn't found in database, it must be scaled.
        /// </remarks>
        public string[]? AvailableBarIntervals { get; set; }

        /// <summary>
        /// Bar intervals that server must storage in database.
        /// </summary>
        public string[]? StorageBarIntervals { get; set; }
    }
}