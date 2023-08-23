using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChartsModule.API.Controllers
{
    /// <summary>
    /// Gets a chart.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GetChart : ControllerBase
    {
        /// <summary>
        /// Provides a series of bars.
        /// </summary>
        /// <returns>Generated series.</returns>
        /// <remarks>
        /// In case of exceeding the limit on bars amount
        /// (e.g. an interval of 100 days was chosen and hourly bars = 2400 bars per request),
        /// the maximum allowed number of bars from the start date is returned.
        /// </remarks>
        /// <response code="200">Returns collected data.</response>
        /// <response code="500">Returns a detailed message with a debug info.</response>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get([FromQuery] ChartRequest request)
        {
            return Ok(new
            {
                tradingPair = request.TradingPair,
                barSize = request.BarSize,
                startDate = request.StartDate,
                endDate = request.EndDate,
            });
        }
    }
}
