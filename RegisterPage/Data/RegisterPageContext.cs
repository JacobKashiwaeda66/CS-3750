using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegisterPage.model;

namespace RegisterPage.Data
{
    public class RegisterPageContext : DbContext
    {
        public RegisterPageContext (DbContextOptions<RegisterPageContext> options)
            : base(options)
        {
        }

        public DbSet<RegisterPage.model.register> register { get; set; } = default!;
    }
}
