using System.Threading.Tasks;

namespace Pokepedia.Shared
{
    public interface ISelectedPokemonRepository
    {
        string Name { get; set; }
        string PokemonId { get; set; }
        Task Clear();
        Task Save(string name, string id);
        Task Load();
    }
}
