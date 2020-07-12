using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PathfinderTools.Pages
{
    public class ErrorModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}