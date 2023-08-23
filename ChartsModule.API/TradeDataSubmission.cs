using System.ComponentModel.DataAnnotations;

namespace ChartsModule.API
{
    /// <summary>
    /// Contains POST parameters for <see cref="Controllers.AddTradeData.Post(TradeDataSubmission)"/> method.
    /// </summary>
    public class TradeDataSubmission
    {
        /// <summary>
        /// Trade pair identifier.
        /// </summary>
        [Required]
        public string? TradingPair { get; set; }
        /// <summary>
        /// Value of the performed order.
        /// </summary>
        [Required]
        public double OrderValue { get; set; }
        /// <summary>
        /// Price of the performed order.
        /// </summary>
        [Required]
        public double OrderPrice { get; set; }
        /// <summary>
        /// Time of registration.
        /// </summary>
        [Required]
        public TimeOnly Time { get; set; }
    }
}
