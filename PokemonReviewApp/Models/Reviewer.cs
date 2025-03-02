// Reviewer.cs

namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        public int Id { get; set; }       
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}

