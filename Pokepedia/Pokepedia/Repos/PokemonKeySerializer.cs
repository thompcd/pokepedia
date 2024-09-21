using Pokepedia.Models;
using Pokepedia.Shared;

namespace Pokepedia.Repos
{
    public static class PokemonKeySerializerExtensions
    {
        public static string ToValue(this IPokemonSummary pokemon)
        {
            var val = $"{pokemon.Id},{pokemon.Name},{pokemon.Height},{pokemon.Order},{pokemon.Weight},{pokemon.FrontSpriteUrl}";
            return val;
        }

        public static IPokemonSummary ToPokemonSummary(this string pokemonKeyValue)
        {
            try
            {
                IPokemonSummary pokemon = null;
                var vals = pokemonKeyValue.Split(',');

                if (vals.Length < 5) { throw new Exception("bad pokemon value in storage"); }

                var poke = new PokemonSummary(
                    Int32.Parse(vals[0] ?? string.Empty),
                    vals[1] ?? string.Empty,
                    Int32.Parse(vals[2] ?? string.Empty),
                    Int32.Parse(vals[3] ?? string.Empty),
                    Int32.Parse(vals[4] ?? string.Empty),
                    vals[5] ?? string.Empty
                    );
                return poke;
            }
            catch (Exception ex)
            {
                return new PokemonSummary(25, "error", 0, 0, 0, "");
            }

        }
    }
}
