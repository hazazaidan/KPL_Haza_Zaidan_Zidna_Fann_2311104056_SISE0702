using Microsoft.AspNetCore.Mvc;
using modul9_NIM.Models;

namespace modul9_NIM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", Director = "Frank Darabont", Stars = new List<string>{"Tim Robbins", "Morgan Freeman"}, Description = "Two imprisoned men bond over a number of years." },
            new Movie { Title = "The Godfather", Director = "Francis Ford Coppola", Stars = new List<string>{"Marlon Brando", "Al Pacino"}, Description = "The aging patriarch of an organized crime dynasty transfers control of his empire to his reluctant son." },
            new Movie { Title = "The Dark Knight", Director = "Christopher Nolan", Stars = new List<string>{"Christian Bale", "Heath Ledger"}, Description = "Batman faces the Joker, a criminal mastermind." }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();

            return movies[id];
        }

        [HttpPost]
        public ActionResult<Movie> AddMovie(Movie movie)
        {
            movies.Add(movie);
            return CreatedAtAction(nameof(GetMovie), new { id = movies.Count - 1 }, movie);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();

            movies.RemoveAt(id);
            return NoContent();
        }
    }
}
