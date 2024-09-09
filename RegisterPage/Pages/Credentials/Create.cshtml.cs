using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegisterPage.Data;
using RegisterPage.model;

namespace RegisterPage.Pages.Credentials
{
    public class CreateModel : PageModel
    {
        private readonly RegisterPage.Data.RegisterPageContext _context;

        public CreateModel(RegisterPage.Data.RegisterPageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public register register { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.register.Add(register);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
