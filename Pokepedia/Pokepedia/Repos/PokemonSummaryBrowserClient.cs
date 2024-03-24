using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;
using PokeApiNet;
using Pokepedia.Models;
using Pokepedia.Shared;

namespace Pokepedia.Repos
{
    public class PokemonSummaryBrowserClient : IPokemonSummaryClient
    {
        private readonly ILogger<PokemonSummaryBrowserClient> _logger;
        private readonly PokeApiClient _pokeApiClient;
        private readonly ILocalStorageService _storageService;
        private List<PokemonSummary> _pokemonSummaries;

        public PokemonSummaryBrowserClient(ILogger<PokemonSummaryBrowserClient> logger, PokeApiClient pokeClient, ILocalStorageService localStorage)
        { 
            _logger = logger;
            _pokeApiClient = pokeClient;
            _storageService = localStorage;

            if (_storageService is null) throw new ArgumentNullException(nameof(_storageService));
            if (_pokeApiClient is null) throw new ArgumentNullException(nameof(_pokeApiClient));
        }

        public async Task<IQueryable<IPokemonSummary>> GetPokemonSummariesAsync()
        {
            _pokemonSummaries = await _storageService.GetItemAsync<List<PokemonSummary>>("pokemons_summary") ?? new List<PokemonSummary>();
            var s = _pokemonSummaries.AsQueryable();
            return s as IQueryable<IPokemonSummary>;
        }

        public async Task FetchAsync(bool force = false)
        {
            await foreach (var poke in _pokeApiClient.GetAllNamedResourcesAsync<Pokemon>())
            {
                if (force || !_pokemonSummaries.Exists(s => string.Equals(s.Name, poke.Name))){
                    _logger?.LogTrace($"pulling info for {poke.Name}");
                    var pokeTemp = await _pokeApiClient.GetResourceAsync<Pokemon>(poke);
                    var pokeSumm = new PokemonSummary(pokeTemp.Id, pokeTemp.Name, pokeTemp.Height, pokeTemp.Order, pokeTemp.Weight, pokeTemp.Sprites.FrontDefault);

                    _pokemonSummaries.Add(pokeSumm);
                    await _storageService.SetItemAsync("pokemons_summary", _pokemonSummaries);
                }
            }
            _logger?.LogTrace("complated update of local pokemons_summary storage");
        }
    }
}
