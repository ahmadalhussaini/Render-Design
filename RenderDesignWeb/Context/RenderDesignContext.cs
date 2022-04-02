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
        public DbSet<ContactMobail> ContactsMobile { get; set; }
        public DbSet<ContactRequests> ContactsRequestss { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Project> Projects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RenderDesign_db;Trusted_Connection=True;");
        }
    }
}
