using FinalProject.Context;
using FinalProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresApiController : ControllerBase
    {

        private readonly MovieContext _context;


        public GenresApiController(MovieContext context)
        {
            _context = context;
        }

        //Action we use to add Genres
        [HttpPost]
        [Route("[action]")]
        public IActionResult GenreAdd([FromBody] Genre genre)
        {
            var createdGenre = _context.Genres.Add(genre);
            _context.SaveChanges();
            return Ok(genre);

        }

        //Action we use to get all genres
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllGenres()
        {
            var genres = _context.Genres.ToList();
            return Ok(genres);
        }

        //Action we use to delete genres
        [HttpDelete("GenreDelete")]
        public void GenreDelete(int id)
        {
            var deletedGenre = _context.Genres.Find(id);
            _context.Genres.Remove(deletedGenre);
            _context.SaveChanges();
        }


    }
}
