using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Infra.Data;

namespace Web.Pages
{
    public class DependencyInjectionModel : PageModel
    {
        public ExampleDbContext Context { get; }
        public List<ExampleEntity> Entities { get; set; }

        public DependencyInjectionModel(ExampleDbContext context) 
        {
            Context = context;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Dependency Injection";
            Entities = Context.ExampleEntities.ToList();
        }
    }
}
