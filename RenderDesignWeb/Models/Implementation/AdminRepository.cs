using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
    public class AdminRepository : IAdminRepository
    {
        RenderDesignContext db;
         public AdminRepository(RenderDesignContext db)
    {
        db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        this.db = db;
    }
    
        public Admin Login(string email, string password)
        {
            var Admin = db.Admins.SingleOrDefault(x => x.Email == email && x.Password == password);

            return Admin;
        }
    }

}