using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegisterPage.model;

namespace RegisterPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IServiceProvider _serviceProvider;

        public IndexModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            if (verify.Check(_serviceProvider, Username, Password))
            {
                return RedirectToPage("/dashboard/dashboard", new { username = Username, password = Password });
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                return Page();
            }
        }
    }
}

