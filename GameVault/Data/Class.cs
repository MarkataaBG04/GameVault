using GameVault.Models;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
