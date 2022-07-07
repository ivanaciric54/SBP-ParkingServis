using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingOracleService.Controllers
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
                return new JsonResult(DataProvider.VratiGaraznaMestaParkinga(parkingID));
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
        public IActionResult AddGaraznoMestoWithProdavnica([FromRoute(Name = "parkingID")] int parkingID, [FromBody] Garazno_mestoView g)
        {
            try
            {
                var parking = DataProvider.VratiParking(parkingID);
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
        public IActionResult ChangeOdeljenjeDo5([FromBody] Garazno_mestoView g)
        {
            try
            {
                DataProvider.IzmeniGaraznoMesto(g);
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
                DataProvider.ObrisiGaraznoMesto(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
