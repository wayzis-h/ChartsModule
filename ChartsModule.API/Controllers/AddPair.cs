using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ChartsModule.API.Controllers
{
    /// <summary>
    /// Adds a trading pair.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AddPair : ControllerBase
    {
        /// <summary>
        /// Registers a new trading pair.
        /// </summary>
        /// <param name="pair">Trading pair.</param>
        /// <returns>Operation status.</returns>
        /// <remarks>
        /// The method is invoked by an administrator on trading data adding in the service.
        /// After putting the pair, service subscribes to an event on given trading pair in the queue broker.
        /// </remarks>
        /// <response code="200">Trades pair has been successfully added.</response>
        /// <response code="500">Returns a detailed message with a debug info.</response>
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([Required][FromQuery] string pair)
        {
            return Ok(new
            {
                pair = pair,
            });
        }
    }
}
