using FunApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FunApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly ILogger<PokemonController> _logger;

        public PokemonController(ILogger<PokemonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pokemon> GetPokemon()
        {
            return new List<Pokemon>();
        }
    }
}