using BoardDealerWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardDealerWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BookingRegister> BookingRegisters { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
