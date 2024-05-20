using Microsoft.EntityFrameworkCore;
using FigWebApi.Models; 

namespace FigWebApi.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Course> Courses { get; set; } 
    }
}
