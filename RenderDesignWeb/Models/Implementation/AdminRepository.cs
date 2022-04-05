using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
    public class AdminRepository : IAdminRepository
    {
       readonly RenderDesignContext db;
         public AdminRepository(RenderDesignContext _db)
    {
            db = _db;
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    
        public Admin Login(string email, string password)
        {
            var Admin = db.Admins.SingleOrDefault(x => x.Email == email && x.Password == password);
            return Admin;
        }
    }

}