using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Shared;

namespace FunApp.Client.Services
{
    // The interface for the code services.
    public interface IPokemonTypeService
    {
        Task<IEnumerable<PokemonType>> GetAllTypes();

        Task<PokemonType> GetType(int typeId);

        Task<PokemonType> AddType(PokemonType type);

        Task<PokemonType> UpdateType(PokemonType type);

        Task DeleteType(int typeId);
    }
}
