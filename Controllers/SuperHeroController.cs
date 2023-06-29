using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<SuperHero>> GetSuperHeros()
        {
            return new List<SuperHero>()
            {
                new SuperHero
                {
                    Name = "Thana",
                    FirstName = "Rith",
                    LastName = "Serey",
                    Place = "PhnomPenh City"
                }
            };
        }
    }
}
