using System.Threading.Tasks;

namespace Pokepedia.Shared
{
    public interface ISelectedPokemonRepository
    {
        string Name { get; set; }
        Task Clear();
        Task Save(string name);
        Task Load();
    }
}
