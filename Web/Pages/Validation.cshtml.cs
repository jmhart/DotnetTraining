using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class ValidationModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Validation";
        }
    }
}
