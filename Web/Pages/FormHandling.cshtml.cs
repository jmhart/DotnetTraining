using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class FormHandlingModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }

        public void OnGet()
        {
            ViewData["Message"] = null;
            ViewData["Title"] = "Form Handling";
        }

        public void OnPost()
        {
            ViewData["Message"] = string.Format("Hello {0}.\\n{1}\\nCurrent Date and Time: {2}", Contact.Name, Contact.Email, DateTime.Now.ToString());
            
            if (ModelState.IsValid)
            {
                // Process the form
            }
        }
    }

    // TODO: Move to Domain.
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}