using MoviesAssignment2.Models; // Importing the Movies model namespace
using MoviesAssignment2.Services; // Importing the service namespace
using Microsoft.AspNetCore.Mvc; // Importing ASP.NET Core MVC namespace
using Microsoft.AspNetCore.Mvc.RazorPages; // Importing ASP.NET Core Razor Pages namespace

namespace MoviesAssignment2.Pages
{
    public class MoviesListModel : PageModel
    {
        // Declaring a field to hold the MovieService instance
        public JsonFileMovieService MovieService;

        // Declaration of the Movie property.
        // This property represents a collection of Movie objects.
        // It is declared as public, allowing external code to read its value,
        // while its setter is private, restricting modification to code within the MovieListModel class.
        // Declaring a property to hold the list of books
        public IEnumerable<Movie> Movies { get; private set; } = default!;

        // Constructor for the MovieListModel class
        // Constructor for the MovieListModel class.
        // It takes two parameters:
        // 1. ILogger<IndexModel> logger: This parameter is of type ILogger, which is a generic interface for logging. 
        //    Here, it is specifically typed to ILogger<IndexModel>, indicating that it will log messages related to the IndexModel class.
        //    However, this parameter seems to be incorrectly typed, as it should be ILogger<BookListModel> instead of ILogger<IndexModel>.
        // 2. JsonFileBookService bookService: This parameter is of type JsonFileBookService, which is a service responsible for handling book data stored in JSON format.
        //    It is used to retrieve books from a JSON file and interact with the book data.

        public MoviesListModel(ILogger<IndexModel> logger, JsonFileMovieService movieService)
        {
            // Assigning the injected book service instance to the BookService field
            MovieService = movieService;
        }

        // Handler method for HTTP GET requests
        public void OnGet()
        {
            // Retrieving the list of books from the BookService
            Movies= MovieService.GetMovies();
        }
    } // class
} // namespace