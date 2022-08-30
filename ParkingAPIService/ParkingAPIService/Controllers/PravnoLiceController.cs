using DatabaseAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PravnoLiceController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPravnoLice/{liceID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPravnoLice(int liceID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiPravnoLice(liceID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPravnoLice/{liceID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPravnoLice([FromRoute(Name = "liceID")] int liceID, [FromBody] PravnoLicePregled pl)
        {
            try
            {
                var lice = DataProvider.vratiPravnoLice(liceID);
                pl.Lice = lice;
                DataProvider.dodajPravnoLice(pl);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniPravnoLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangePravnoLice([FromBody] PravnoLicePregled pl)
        {
            try
            {
                DataProvider.izmeniPravnoLice(pl);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPravnoLice/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePravnoLice(int id)
        {
            try
            {
                DataProvider.izbrisiPravnoLice(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
