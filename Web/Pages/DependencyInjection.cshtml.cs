using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class DependencyInjectionModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Dependency Injection";
        }
    }
}
