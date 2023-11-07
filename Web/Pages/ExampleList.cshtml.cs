using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class ExampleListModel : PageModel
    {
        public IList<string> ExampleList { get; set; } = default!;
        
        public void OnGet()
        {
            ViewData["Title"] = "Examples";
        }
    }
}
