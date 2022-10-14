using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FunApp.Client.Services;
using FunApp.Shared;

namespace FunApp.Client.Services
{
    public class PokemonTypeService : IPokemonTypeService
    {
        private readonly HttpClient httpClient;

        // The constructor for code services.
        public PokemonTypeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public async Task<PokemonType> AddType(PokemonType type)
        {
            var response = await httpClient.PostAsJsonAsync<PokemonType>("/api/pokemontype", type);
            return await response.Content.ReadFromJsonAsync<PokemonType>();
        }

        public async Task DeleteType(int typeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PokemonType>> GetAllTypes()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<PokemonType>>("/api/pokemontype/all");
        }

        public async Task<PokemonType> GetType(int typeId)
        {
            return await httpClient.GetFromJsonAsync<PokemonType>($"/api/pokemontype/{typeId}");
        }

        public async Task<PokemonType> UpdateType(PokemonType type)
        {
            throw new NotImplementedException();
        }
    }
}
