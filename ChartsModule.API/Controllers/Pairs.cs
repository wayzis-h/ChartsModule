using ChartsModule.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ChartsModule.API.Controllers
{
    /// <summary>
    /// Controlls trading pairs.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class Pairs : ControllerBase
    {
        /// <summary>
        /// Provides a complete list of registered trading pairs.
        /// </summary>
        /// <returns>The list of registered trading pairs</returns>
        /// <response code="200">Successfully queried data.</response>
        /// <response code="500">Returns a detailed message with a debug info.</response>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            Pair[] stubData = new[] {
                new Pair() {
                    Name = "TEST-DBG",
                    PrecisionPrice = 8,
                    PrecisionAmount = 8,
                    AvailableBarIntervals = new[] { "1m", "3m" },
                    StorageBarIntervals = new[] {
                        "1m", "5m", "15m", "1h", "4h", "6h", "12h", "1d", "3d", "4d"
                    }
                },
                new Pair() {
                    Name = "DBG-TEST",
                    PrecisionPrice = 8,
                    PrecisionAmount = 8,
                    AvailableBarIntervals = new[] { "1m", "3m" },
                    StorageBarIntervals = new[] {
                        "1m", "5m", "15m", "1h", "4h", "6h", "12h", "1d", "3d", "4d"
                    }
                },
            };
            return Ok(stubData);
        }

        /// <summary>
        /// Registers a new trading pair.
        /// </summary>
        /// <param name="pair">Trading pair.</param>
        /// <returns>Operation status.</returns>
        /// <remarks>
        /// The method is invoked by an administrator on trading data adding in the service.
        /// After putting the pair, service subscribes to an event on given trading pair in the queue broker.
        /// </remarks>
        /// <response code="201">Trades pair has been successfully added.</response>
        /// <response code="500">Returns a detailed message with a debug info.</response>
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post([Required][FromQuery] string pair)
        {
            return CreatedAtAction(nameof(GetPair), pair, new Pair() {
                Name = pair,
                PrecisionPrice = 8,
                PrecisionAmount = 8,
                AvailableBarIntervals = new[] { "1m", "3m" },
                StorageBarIntervals = new[] {
                    "1m", "5m", "15m", "1h", "4h", "6h", "12h", "1d", "3d", "4d"
                }
            });
        }

        /// <summary>
        /// Gets data of the selected pair.
        /// </summary>
        /// <param name="pair">Code of a trading pair.</param>
        /// <returns>Full info about the trading pair.</returns>
        /// <response code="200">Successfully queried data.</response>
        /// <response code="500">Returns a detailed message with a debug info.</response>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetPair([Required][FromQuery] string pair)
        {
            return Ok(new Pair()
            {
                Name = pair,
                PrecisionPrice = 8,
                PrecisionAmount = 8,
                AvailableBarIntervals = new[] { "1m", "3m" },
                StorageBarIntervals = new[] {
                    "1m", "5m", "15m", "1h", "4h", "6h", "12h", "1d", "3d", "4d"
                }
            });
        }
    }
}
