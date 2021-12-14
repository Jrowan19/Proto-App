using DemoForm.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoForm.Data
{
    public class ApplicationDbContext : DbContext
    {

        //Critical line of code or connection to Db wont work
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }

        public DbSet<Timesheets> Timesheets { get; set; }

        public DbSet<Category> Category { get; set; }

    }
}
