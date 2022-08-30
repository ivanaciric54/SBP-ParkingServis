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
    public class VoziloController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVozilo/{parkingID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVozilo(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvaVozila());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVozilo/{voziloID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVozilo([FromRoute(Name = "voziloID")] int voziloID, [FromBody] VoziloPregled v)
        {
            try
            {
                var vozilo = DataProvider.vratiVozilo(voziloID);
                v.Vozilo = vozilo;
                DataProvider.dodajVozilo(v);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniVozilo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeVozilo([FromBody] VoziloPregled v)
        {
            try
            {
                DataProvider.izmeniVozilo(v);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiVozilo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVozilo(int id)
        {
            try
            {
                DataProvider.izbrisiVozilo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
