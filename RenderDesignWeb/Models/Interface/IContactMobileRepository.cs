using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IContactMobileRepository
    {
        List<ContactMobail> GetContactMobails();
        ContactMobail GetContactMobail(int Id);
        ContactMobail Add(ContactMobail contactMobail);
        void Delete(ContactMobail contactMobail);
    }
}
