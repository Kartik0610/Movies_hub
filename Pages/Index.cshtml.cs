using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviesAssignment2.Pages
{
    // IndexModel class represents the code-behind file for the Index page.
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // Constructor for the IndexModel class.
        // It takes ILogger<IndexModel> as a parameter to enable logging functionality.
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // OnGet method is called when the page is requested using the HTTP GET method.
        public void OnGet()
        {
            // This method is currently empty, as no additional logic is implemented for the GET request.
        }
    }
}
