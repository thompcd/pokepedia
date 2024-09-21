using System.Threading.Tasks;

namespace Pokepedia.Shared
{
    public interface ISelectedPokemonRepository
    {
        IPokemonSummary Pokemon { get; set; }
        string Name { get; set; }
        Task Clear();
        Task Save(IPokemonSummary pokemon);
        Task Save(string pokemon);
        Task Load();
    }
}
