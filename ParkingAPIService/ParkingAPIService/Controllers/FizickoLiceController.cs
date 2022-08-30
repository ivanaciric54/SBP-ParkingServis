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
    public class FizickoLiceController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiFizickoLice/{liceID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetFizickoLice(int liceID)
        {
            try
            {
                return new JsonResult(DataProvider.vratiFizickoLice(liceID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajFizickoLice/{liceID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddFizickoLice([FromRoute(Name = "liceID")] int liceID, [FromBody] FizickoLicePregled f)
        {
            try
            {
                var lice = DataProvider.vratiFizickoLice(liceID);
                f.Lice = lice;
                DataProvider.dodajFizickoLice(f);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniFizickoLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeFizickoLice([FromBody] FizickoLicePregled fl)
        {
            try
            {
                DataProvider.izmeniFizickoLice(fl);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiFizickoLice/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteFizickoLice(int id)
        {
            try
            {
                DataProvider.izbrisiFizickoLice(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
