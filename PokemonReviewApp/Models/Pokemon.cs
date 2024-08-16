namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public string name {  get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public ICollection<Review> reviews { get; set; }
        public ICollection<PokemonOwners> pokemonOwners { get; set; }
        public ICollection<PokemonCategories> pokemonCategories { get; set; }

    }
}
