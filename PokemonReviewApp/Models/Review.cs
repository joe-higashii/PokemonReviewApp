// Review.cs

namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Text { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}

