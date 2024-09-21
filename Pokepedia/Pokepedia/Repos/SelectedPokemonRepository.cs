using Blazored.LocalStorage;
using Pokepedia.Repos;
using System.Runtime.CompilerServices;

namespace Pokepedia.Shared
{
    /// <summary>
    /// Local-first storage with a lazy load from cache
    /// </summary>
    public class SelectedPokemonRepository : ISelectedPokemonRepository
    {
        private readonly ILogger<SelectedPokemonRepository> _logger;
        private readonly ILocalStorageService _storageService;
        private const string _keyPokeId= "selected_pokemon_id";
        private const string _keyPokeName= "selected_pokemon_name";

        public SelectedPokemonRepository(ILogger<SelectedPokemonRepository> logger, ILocalStorageService localStorage)
        {
            _logger = logger;
            _storageService = localStorage ?? throw new ArgumentNullException(nameof(_storageService));
        }

        public string Name { get; set; }

        //private IPokemonSummary _pokemon;
        /// <summary>
        /// Lazy load name from repository.
        /// </summary>
        public IPokemonSummary Pokemon { get; set; }
        //{
        //    get { return _pokemon; }
        //    set
        //    {
        //        if (_pokemon != value)
        //        {
        //            Save(value);
        //            _pokemon = value;
        //        }
        //    }
        //}

        public async Task Load()
        {
            var val = await _storageService.GetItemAsStringAsync(_keyPokeId);
            Pokemon = val.ToPokemonSummary();
            Name = await _storageService.GetItemAsStringAsync(_keyPokeName) ?? string.Empty;
        }

        public async Task Clear()
        {
            var Name = string.Empty;
            await _storageService.SetItemAsStringAsync(_keyPokeId, Name);
            await _storageService.SetItemAsStringAsync(_keyPokeName, Name);
        }

        public async Task Save(string name)
        {
            Name = name;
            await _storageService.SetItemAsStringAsync(_keyPokeName, Name);
        }

        public async Task Save(IPokemonSummary pokemon)
        {
            Pokemon = pokemon;
            await Save(pokemon.Name);
            await _storageService.SetItemAsStringAsync(_keyPokeId, Pokemon.ToValue());
        }
    }
}
