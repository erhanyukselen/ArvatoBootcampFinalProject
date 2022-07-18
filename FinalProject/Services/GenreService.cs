using FinalProject.Entities;

namespace FinalProject.Services
{
    public class GenreService
    {
        public interface IGenreService
        {
            Task<List<Genre>> ListGenres();
            Task<Genre> AddGenre(Genre movie);
            Task<Genre> GetGenreById(int id);
            Task<Genre> UpdateGenre(Genre movie);
            Task DeleteGenre(int id);
        }
    }
}
