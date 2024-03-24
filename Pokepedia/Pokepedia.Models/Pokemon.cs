using Pokepedia.Shared;
using System.Text.Json.Serialization;

namespace Pokepedia.Models
{
    // Pokemon myDeserializedClass = JsonSerializer.Deserialize<Pokemon>(myJsonResponse);

    public record PokemonSummary(int Id, string Name, int Height, int Order, int Weight, string FrontSpriteUrl) : IPokemonSummary;

    public class PokemonFull
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("base_experience")]
        public int base_experience { get; set; }

        [JsonPropertyName("Height")]
        public int Height { get; set; }

        [JsonPropertyName("is_default")]
        public bool is_default { get; set; }

        [JsonPropertyName("Order")]
        public int Order { get; set; }

        [JsonPropertyName("Weight")]
        public int Weight { get; set; }

        [JsonPropertyName("Abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonPropertyName("Forms")]
        public List<Form> Forms { get; set; }

        [JsonPropertyName("game_indices")]
        public List<GameIndex> game_indices { get; set; }

        [JsonPropertyName("held_items")]
        public List<object> held_items { get; set; }

        [JsonPropertyName("location_area_encounters")]
        public string location_area_encounters { get; set; }

        [JsonPropertyName("Moves")]
        public List<Move> Moves { get; set; }

        [JsonPropertyName("past_types")]
        public List<object> past_types { get; set; }

        [JsonPropertyName("Sprites")]
        public Sprites Sprites { get; set; }

        [JsonPropertyName("Species")]
        public Species Species { get; set; }

        [JsonPropertyName("Stats")]
        public List<Stat> Stats { get; set; }

        [JsonPropertyName("Types")]
        public List<Type> Types { get; set; }
    }
    public class Ability
    {
        [JsonPropertyName("is_hidden")]
        public bool is_hidden { get; set; }

        [JsonPropertyName("Slot")]
        public int Slot { get; set; }

        [JsonPropertyName("Ability")]
        public AbilityRef AbilityRef { get; set; }
    }

    public class AbilityRef
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class Animated
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class BlackWhite
    {
        [JsonPropertyName("Animated")]
        public Animated Animated { get; set; }

        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Crystal
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("back_shiny_transparent")]
        public string back_shiny_transparent { get; set; }

        [JsonPropertyName("back_transparent")]
        public string back_transparent { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_transparent")]
        public string front_shiny_transparent { get; set; }

        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class DiamondPearl
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class DreamWorld
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }
    }

    public class Emerald
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class FireredLeafgreen
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class Form
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class GameIndex
    {
        [JsonPropertyName("game_index")]
        public int game_index { get; set; }

        [JsonPropertyName("Version")]
        public Version Version { get; set; }
    }

    public class GenerationI
    {
        [JsonPropertyName("red-blue")]
        public RedBlue redblue { get; set; }

        [JsonPropertyName("Yellow")]
        public Yellow Yellow { get; set; }
    }

    public class GenerationIi
    {
        [JsonPropertyName("Crystal")]
        public Crystal Crystal { get; set; }

        [JsonPropertyName("Gold")]
        public Gold Gold { get; set; }

        [JsonPropertyName("Silver")]
        public Silver Silver { get; set; }
    }

    public class GenerationIii
    {
        [JsonPropertyName("emerald")]
        public Emerald emerald { get; set; }

        [JsonPropertyName("firered-leafgreen")]
        public FireredLeafgreen fireredleafgreen { get; set; }

        [JsonPropertyName("ruby-sapphire")]
        public RubySapphire rubysapphire { get; set; }
    }

    public class GenerationIv
    {
        [JsonPropertyName("diamond-pearl")]
        public DiamondPearl diamondpearl { get; set; }

        [JsonPropertyName("heartgold-soulsilver")]
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }

        [JsonPropertyName("Platinum")]
        public Platinum Platinum { get; set; }
    }

    public class GenerationV
    {
        [JsonPropertyName("black-white")]
        public BlackWhite blackwhite { get; set; }
    }

    public class GenerationVi
    {
        [JsonPropertyName("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }

        [JsonPropertyName("x-y")]
        public XY xy { get; set; }
    }

    public class GenerationVii
    {
        [JsonPropertyName("Icons")]
        public Icons Icons { get; set; }

        [JsonPropertyName("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon ultrasunultramoon { get; set; }
    }

    public class GenerationViii
    {
        [JsonPropertyName("Icons")]
        public Icons Icons { get; set; }
    }

    public class Gold
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Home
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Icons
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }
    }

    public class Move
    {
        [JsonPropertyName("Move")]
        public MoveRef MoveRef { get; set; }

        [JsonPropertyName("version_group_details")]
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class MoveRef
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class MoveLearnMethod
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Other
    {
        [JsonPropertyName("dream_world")]
        public DreamWorld dream_world { get; set; }

        [JsonPropertyName("Home")]
        public Home Home { get; set; }

        [JsonPropertyName("official-artwork")]
        public OfficialArtwork officialartwork { get; set; }
    }

    public class Platinum
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class RedBlue
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_gray")]
        public string back_gray { get; set; }

        [JsonPropertyName("back_transparent")]
        public string back_transparent { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_gray")]
        public string front_gray { get; set; }

        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class RubySapphire
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class Silver
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class Species
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }

        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_shiny")]
        public string back_shiny { get; set; }

        [JsonPropertyName("back_female")]
        public object back_female { get; set; }

        [JsonPropertyName("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonPropertyName("Other")]
        public Other Other { get; set; }

        [JsonPropertyName("Versions")]
        public Versions Versions { get; set; }
    }

    public class Stat
    {
        [JsonPropertyName("Stat")]
        public StatRef StatRef { get; set; }

        [JsonPropertyName("Effort")]
        public int Effort { get; set; }

        [JsonPropertyName("base_stat")]
        public int base_stat { get; set; }
    }

    public class StatRef
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class Type
    {
        [JsonPropertyName("Slot")]
        public int Slot { get; set; }

        [JsonPropertyName("Type")]
        public TypeRef TypeRef { get; set; }
    }

    public class TypeRef
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class UltraSunUltraMoon
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Version
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class VersionGroup
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class VersionGroupDetail
    {
        [JsonPropertyName("move_learn_method")]
        public MoveLearnMethod move_learn_method { get; set; }

        [JsonPropertyName("version_group")]
        public VersionGroup version_group { get; set; }

        [JsonPropertyName("level_learned_at")]
        public int level_learned_at { get; set; }
    }

    public class Versions
    {
        [JsonPropertyName("generation-i")]
        public GenerationI generationi { get; set; }

        [JsonPropertyName("generation-ii")]
        public GenerationIi generationii { get; set; }

        [JsonPropertyName("generation-iii")]
        public GenerationIii generationiii { get; set; }

        [JsonPropertyName("generation-iv")]
        public GenerationIv generationiv { get; set; }

        [JsonPropertyName("generation-v")]
        public GenerationV generationv { get; set; }

        [JsonPropertyName("generation-vi")]
        public GenerationVi generationvi { get; set; }

        [JsonPropertyName("generation-vii")]
        public GenerationVii generationvii { get; set; }

        [JsonPropertyName("generation-viii")]
        public GenerationViii generationviii { get; set; }
    }

    public class XY
    {
        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_female")]
        public object front_female { get; set; }

        [JsonPropertyName("front_shiny")]
        public string front_shiny { get; set; }

        [JsonPropertyName("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Yellow
    {
        [JsonPropertyName("back_default")]
        public string back_default { get; set; }

        [JsonPropertyName("back_gray")]
        public string back_gray { get; set; }

        [JsonPropertyName("back_transparent")]
        public string back_transparent { get; set; }

        [JsonPropertyName("front_default")]
        public string front_default { get; set; }

        [JsonPropertyName("front_gray")]
        public string front_gray { get; set; }

        [JsonPropertyName("front_transparent")]
        public string front_transparent { get; set; }
    }


}
