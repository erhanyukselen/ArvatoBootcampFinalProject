using FinalProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesApiController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddMovie([FromBody] MovieEntities movie)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok();
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

    }
}
