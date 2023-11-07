using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class WorkingWithDataModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Working With Data";
        }
    }
}
