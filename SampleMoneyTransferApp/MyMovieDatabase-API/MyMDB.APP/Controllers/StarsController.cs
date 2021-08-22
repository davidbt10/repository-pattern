using Microsoft.AspNetCore.Mvc;
using MyMDB.APP.Data.EFCore;
using MyMDB.APP.Models;

namespace MyMDB.APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyMDBController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}
