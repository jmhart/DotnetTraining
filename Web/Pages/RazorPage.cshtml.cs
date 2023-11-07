using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class RazorPageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Razor Page";
        }
    }
}
