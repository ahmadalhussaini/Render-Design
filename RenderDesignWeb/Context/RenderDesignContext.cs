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
        public DbSet<ContactMobile> ContactsMobile { get; set; }
        public DbSet<ContactRequests> ContactsRequestss { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public object ContactMobile { get; internal set; }
        public object ContactRequests { get; internal set; }
        public object Designer { get; internal set; }
        public object Image { get; internal set; }
        public object Post { get; internal set; }
        public object Project { get; internal set; }
        public object Admin { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RenderDesign_db;Trusted_Connection=True;");
        }
    }
}
