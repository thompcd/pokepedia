using System;

namespace Pokepedia.Shared
{
    public interface IPokemonSummary
    {
        int Id { get; }
        string Name { get; }
        int Height { get; }
        int Order { get; }
        int Weight { get; }
        string FrontSpriteUrl { get; }
    }
}
