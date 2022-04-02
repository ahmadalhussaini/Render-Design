using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IContactRequestsRepository
    {
        List<ContactRequests> GetContactRequests();
        ContactRequests GetContactRequests(int Id);
        ContactRequests Add(ContactRequests contactrequests);
        void Delete(ContactRequests contactRequests);
    }
}
