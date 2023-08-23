using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChartsModule.API.Controllers
{
    /// <summary>
    /// Adds trade data.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AddTradeData : ControllerBase
    {
        /// <summary>
        /// Writes new order details into the database.
        /// </summary>
        /// <returns>Operation status.</returns>
        /// <remarks>
        /// On trade date adding it is necessary to change all data in all the bars
        /// in the interval of which the received trade data included.
        /// <br/>
        /// For example: there are 15min bars in the base,
        /// but the trade data has been received for the time 16:08, that means it should be put into the 16:00-16:15 bar.
        /// <br/>
        /// On data adding, the following should be updated:
        /// <br/>- Open price (if there wasn't added trade data in the bar)
        /// <br/>- Close price (in any case)
        /// <br/>- Maximum price (if the max price of the trade data is higher than the max price of the bar)
        /// <br/>- Minimum price (if the min price of the received data is lower than the min price of the bar)
        /// </remarks>
        /// <response code="200">Trade data has been successfully added.</response>
        /// <response code="500">Returns a detailed message with a debug info.</response>
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([FromBody] TradeDataSubmission request)
        {
            return Ok(new
            {
                tradingPair = request.TradingPair,
                orderValue = request.OrderValue,
                orderPrice = request.OrderPrice,
                time = request.Time,
            });
        }
    }
}
