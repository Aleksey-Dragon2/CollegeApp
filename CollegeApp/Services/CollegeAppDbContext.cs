using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollegeApp.Services
{
    public class CollegeAppDbContext : IdentityDbContext
    {
        public CollegeAppDbContext(DbContextOptions<CollegeAppDbContext> options)
            : base(options)
        {
            
        }
    }
}
