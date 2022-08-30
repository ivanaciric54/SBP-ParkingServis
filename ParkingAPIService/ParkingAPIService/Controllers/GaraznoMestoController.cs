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
    public class GaraznoMestoController : ControllerBase

    {
        [HttpGet]
        [Route("PreuzmiGaraznoMesto/{parkingID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGaraznaMesta(int parkingID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvaGaraznaMesta(parkingID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajGaraznoMesto/{parkingID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddGaraznoMestoWithProdavnica([FromRoute(Name = "parkingID")] int parkingID, [FromBody] GaraznoMestoPregled g)
        {
            try
            {
                var parking = DataProvider.vratiParking(parkingID);
                g.Parking = parking;
                DataProvider.SacuvajGaraznoMesto(g);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniGaraznoMesto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeOdeljenjeDo5([FromBody] GaraznoMestoPregled g)
        {
            try
            {
                DataProvider.izmeniGaraznoMesto(g);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiGaraznoMesto/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteGaraznoMesto(int id)
        {
            try
            {
                DataProvider.izbrisiGaraznoMesto(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
