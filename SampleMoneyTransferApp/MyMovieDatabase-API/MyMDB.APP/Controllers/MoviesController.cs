using Microsoft.AspNetCore.Mvc;
using MyMDB.APP.Data.EFCore;
using MyMDB.APP.Models;

namespace MyMDB.APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMDBController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}
