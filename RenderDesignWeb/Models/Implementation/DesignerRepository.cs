using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
    public class DesignerRepository : IDesignerRepository
    {
        readonly RenderDesignContext db;
        public DesignerRepository(RenderDesignContext db)
        {
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.db = db;
        }
        public void Delete(Designer entity)
        {
            db.Designers.Remove(entity);
            db.SaveChanges();
        }

        public List<Designer> GetDesigner()
        {
            var designer = db.Designers.ToList();
            return designer;
        }

        public Project GetPDesigner(int Id)
        {
            var designer = db.Designers.SingleOrDefault(b => b.Id == Id).Project;
            return (Project)designer;
        }

        public Designer Login(string email, string password)
        {
            var designer = db.Designers.SingleOrDefault(x => x.Email == email && x.Password == password);

            return designer;
        }

        public Designer Register(Designer entity)
        {
            var designer= db.Designers.Add(entity);
            db.SaveChanges();
            return designer.Entity;
        }

        public void Update(Designer entity)
        {
            db.Designers.Update(entity);
            db.SaveChanges();
        }
    }
}
