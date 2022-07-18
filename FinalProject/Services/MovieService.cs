using FinalProject.Entities;

namespace FinalProject.Services
{
    public class MovieService
    {
        public interface IMovieService
        {
            MovieEntities GetMovieDetail(long id);
            IEnumerable<MovieEntities> GetMovieListByGenreId(int id);
            List<MovieEntities> GetMovieListByRateFilter(int rate);
            IEnumerable<MovieEntities> GetMovieListByRelaseDate(string date);
            IEnumerable<MovieEntities> Search(string title, string rate, string year);
            MovieEntities AddMovie(MovieEntities movie);
            MovieEntities UpdateMovie(MovieEntities movie);
            void DeleteMovie(int id);
            List<MovieEntities> GetMovies();
            IEnumerable<MovieEntities> ListMostViewed10Movies();
            IEnumerable<MovieEntities> ListTopRated10Movies();
        }
    }
}
