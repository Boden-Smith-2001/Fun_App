using FunApp.Server.Models;
using FunApp.Shared;
using Microsoft.AspNetCore.Mvc;
using teamDrummerCapstone.Server.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FunApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonTypeController : ControllerBase
    {
        private readonly ILogger<PokemonTypeController> _logger;

        private PokemonTypeRepository repo = new PokemonTypeRepository(new DbConnection());

        public PokemonTypeController(ILogger<PokemonTypeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("all")]
        public IEnumerable<PokemonType> GetPokemonTypes()
        {
           var types = repo.GetAllTypes();

           return types;
        }

        [HttpPost]
        //Tells the company repository to create the company  
        public async Task<ActionResult<PokemonType>> CreateType(PokemonType type)
        {
            try
            {
                if (type == null)
                    return BadRequest();

                var createdCompany = await companyRepository.AddCompany(company);

                return CreatedAtAction(nameof(GetCompany),
                    new { id = createdCompany.Id }, createdCompany);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new company record");
            }
        }

    }
}