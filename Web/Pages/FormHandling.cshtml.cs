using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class FormHandlingModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Form Handling";
        }
    }
}
