using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
    public class ContactMobileRepository : IContactMobileRepository
    {
        readonly RenderDesignContext db;
        public ContactMobileRepository(RenderDesignContext db)
        {
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.db = db;
        }

        public ContactMobile Add(ContactMobile entity)
        {
            var contactmobile = db.ContactsMobile.Add(entity);
            db.SaveChanges();
            return contactmobile.Entity;
        }

        public void Delete(ContactMobile entity)
        {
            db.ContactsMobile.Remove(entity);
            db.SaveChanges();
        }

        public ContactMobile GetContactMobail(int Id)
        {
            var contactmobile = db.ContactsMobile.SingleOrDefault(b => b.Id == Id);
            return contactmobile;
        }

        public List<ContactMobile> GetContactMobails()
        {
            var contactmobile = db.ContactsMobile.ToList();
            return contactmobile;
        }
    }
}
