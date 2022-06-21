using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingLibrary;
using ParkingLibrary.DTOs;
using Microsoft.AspNetCore.Http;
using DatabaseAccess;

namespace ParkingOracleService.Controllers
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
                return new JsonResult(DataProvider.VratiSveParkinge());
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
        public IActionResult AddParking([FromBody]ParkingView parking)
        {
            try
            {
                DataProvider.DodajParking(parking);
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
        public IActionResult ChangeParking([FromBody] ParkingView parking)
        {
            try
            {
                DataProvider.AzurirajParking(parking);
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
        public IActionResult DeleteParking([FromRoute(Name ="parkingID")] int id)
        {
            try
            {
                DataProvider.ObrisiParking(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
