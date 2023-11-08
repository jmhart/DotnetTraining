using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages
{
    public class ValidationModel : PageModel
    {
        [BindProperty]
        public PizzaOrder PizzaOrder { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Validation";
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            // Process the form
        }
    }

    // TODO: Move classes to Domain.Entities.
    public class PizzaOrder
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public PizzaSize Size { get; set; }
        public IList<Topping> Toppings { get; set; }
    }

    public class Topping {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum PizzaSize {
        Small,
        Medium,
        Large
    }
}
