using System.Text.Json;
using System.Text.Json.Serialization;

namespace MoviesAssignment2.Models
{
    // Represents a movie entity with its properties.
    public class Movie
    {
        // Gets or sets the title of the movie.
        public string? Title { get; set; }

        // Gets or sets the director of the movie.
        public string? Director { get; set; }

        // Gets or sets the image URL of the movie.
        public string? Img { get; set; }

        // Gets or sets the genre of the movie.
        public string? Genre { get; set; }

        // Overrides the ToString method to serialize the movie object to JSON format.
        public override string ToString() => JsonSerializer.Serialize<Movie>(this);
    } // class
} // namespace
