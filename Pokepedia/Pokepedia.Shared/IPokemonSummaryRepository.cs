using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokepedia.Shared
{
    public interface IPokemonSummaryClient
    {
        Task<IQueryable<IPokemonSummary>> GetPokemonSummariesAsync();
        Task FetchAsync(bool force = false);
    }
}
