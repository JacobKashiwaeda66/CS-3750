using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegisterPage.Data;

namespace RegisterPage.Pages.Dashboard
{
    public class Dashboard : PageModel
    {
        private readonly IServiceProvider _serviceProvider;

        public Dashboard(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet(string username, string password)
        {
            using (var context = new RegisterPageContext(
                _serviceProvider.GetRequiredService<DbContextOptions<RegisterPageContext>>()))
            {
                var user = context.register
                    .SingleOrDefault(u => u.username == username && u.password == password);

                
                    FirstName = user.firstname;
                    LastName = user.lastname;
            }
        }
    }
}
