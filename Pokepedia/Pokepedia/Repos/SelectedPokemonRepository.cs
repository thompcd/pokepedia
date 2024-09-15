using Blazored.LocalStorage;
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
        private const string _keyName = "selected_pokemon_name";

        public SelectedPokemonRepository(ILogger<SelectedPokemonRepository> logger, ILocalStorageService localStorage)
        {
            _logger = logger;
            _storageService = localStorage ?? throw new ArgumentNullException(nameof(_storageService));
        }

        /// <summary>
        /// Lazy load name from repository.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public async Task Load()
        {
           Name = await _storageService.GetItemAsStringAsync(_keyName) ?? string.Empty;
        }

        public async Task Clear()
        {
            Name = string.Empty;
            await _storageService.SetItemAsStringAsync(_keyName, Name);
        }

        public async Task Save(string name)
        {
            Name = name;
            await _storageService.SetItemAsStringAsync(_keyName, Name);
        }
    }
}
