using MoviesAssignment2.Models; // Importing the namespace for the Movie class from the Models folder.
using System.Text.Json; // Importing the namespace for handling JSON data.

namespace MoviesAssignment2.Services
{
    // Service class responsible for providing movie data from a JSON file.
    public class JsonFileMovieService
    {
        // Constructor for the JsonFileMovieService class.
        // It takes an IWebHostEnvironment parameter to access information about the web hosting environment.
        public JsonFileMovieService(IWebHostEnvironment webHostEnvironment)
        {
            // Assigning the provided web hosting environment to the WebHostEnvironment property.
            WebHostEnvironment = webHostEnvironment;
        }

        // Property to store the web hosting environment.
        // Only getter is used here as the WebHostEnvironment remains constant.
        public IWebHostEnvironment WebHostEnvironment { get; }

        // Combining the file path for the JSON file containing movie data.
        // The JSON file is located in the "wwwroot/data" folder.
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "movies.json");

        // Method to retrieve a collection of Movie objects from a JSON file.
        public IEnumerable<Movie> GetMovies()
        {
            // Open the JSON file containing movie data for reading.
            using var jsonFileReader = File.OpenText(JsonFileName);

            // Deserialize the JSON data into an array of Movie objects.
            // Deserialize the entire content of the JSON file as a string and convert it into Movie objects.
            // PropertyNameCaseInsensitive is set to true to ensure case-insensitive matching of property names.
            return JsonSerializer.Deserialize<Movie[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;
        }
    }
}
