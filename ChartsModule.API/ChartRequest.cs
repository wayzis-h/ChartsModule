using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ChartsModule.API
{
    /// <summary>
    /// Contains get parameters for <see cref="Controllers.GetChart.Get(ChartRequest)"/> method.
    /// </summary>
    public class ChartRequest
    {
        /// <summary>
        /// Trading pair
        /// </summary>
        [Required]
        public string? TradingPair { get; set; }
        /// <summary>
        /// The size of bars
        /// </summary>
        [Required]
        public string? BarSize { get; set; }
        /// <summary>
        /// Start date
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// End date
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; }
    }
}
