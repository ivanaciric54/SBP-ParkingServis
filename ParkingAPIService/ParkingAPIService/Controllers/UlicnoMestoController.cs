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
    public class UlicnoMestoController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiUlicnoMesto/{parkingID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUlicnanaMesta(int parkingID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvaUlicnaMesta());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajUlicnoMesto/{parkingID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddGaraznoMestoWithProdavnica([FromRoute(Name = "parkingID")] int parkingID, [FromBody] UlicnoMestoPregled u)
        {
            try
            {
                var parking = DataProvider.vratiParking(parkingID);
                u.Parking = parking;
                DataProvider.dodajUlicnoMesto(u);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniUlicnoMesto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PromeniUlicnoMesto([FromBody] UlicnoMestoPregled u)
        {
            try
            {
                DataProvider.izmeniUlicnoMesto(u);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiUlicnoMesto/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteUlicnoMesto(int id)
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
