using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class ExampleListModel : PageModel
    {
        public IList<string> Examples { get; set; } = default!;
        
        public void OnGet()
        {
            ViewData["Title"] = "Examples";
            Examples = new List<string>() {
                "RazorPage",
                "DependencyInjection",
                "FormHandling",
                "Validation",
                "WorkingWithData"
            };
        }
    }
}
