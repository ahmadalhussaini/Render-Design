using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Models;

namespace RenderDesignWeb.Context
{
    public class RenderDesignContext : DbContext
    {
        public RenderDesignContext(DbContextOptions<RenderDesignContext> options) : base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RenderDesign_db;Trusted_Connection=True;");
        }
    }
}
