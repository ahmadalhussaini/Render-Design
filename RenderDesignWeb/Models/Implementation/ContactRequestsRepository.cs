using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
   
    public class ContactRequestsRepository : IContactRequestsRepository
    {
        readonly RenderDesignContext db;
        public ContactRequestsRepository(RenderDesignContext db)
        {
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.db = db;
        }
        public ContactRequests Add(ContactRequests entity)
        {
            var contactrequests = db.ContactsRequestss.Add(entity);
            db.SaveChanges();
            return contactrequests.Entity;
        }

        public void Delete(ContactRequests entity)
        {
            db.ContactsRequestss.Remove(entity);
            db.SaveChanges();
        }

        public List<ContactRequests> GetContactRequests()
        {
            var contactrequests = db.ContactsRequestss.ToList();
            return contactrequests;
        }

        public ContactRequests GetContactRequests(int Id)
        {
            var contactrequests = db.ContactsRequestss.SingleOrDefault(b => b.Id == Id);
            return contactrequests;
        }
    }
}
