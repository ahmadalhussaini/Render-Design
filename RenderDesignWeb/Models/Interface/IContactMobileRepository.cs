using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IContactMobileRepository
    {
        List<ContactMobile> GetContactMobails();
        ContactMobile GetContactMobail(int Id);
        ContactMobile Add(ContactMobile contactMobail);
        void Delete(ContactMobile contactMobail);
    }
}
