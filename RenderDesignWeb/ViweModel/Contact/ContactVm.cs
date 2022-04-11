using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.ViweModel.Contact
{
    public class ContactListVm
    {
        public List<ContactVm> Contacts { get; set; }

       
    }
    public class ContactVm
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }
    }
}
