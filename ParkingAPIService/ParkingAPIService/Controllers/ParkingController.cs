using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAccess;

namespace ParkingAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiParkinge")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetParkinzi()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveParkinge());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
        }

        [HttpPost]
        [Route("DodajParking")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddParking([FromBody] ParkingPregled parking)
        {
            try
            {
                DataProvider.dodajParking(parking);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniParking")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeParking([FromBody] ParkingPregled parking)
        {
            try
            {
                DataProvider.izmeniParking(parking);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiParking/{id}")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteParking([FromRoute(Name = "parkingID")] int id)
        {
            try
            {
                DataProvider.izbrisiParking(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
