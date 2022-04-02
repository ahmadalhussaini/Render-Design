using RenderDesignWeb.Models.Interface;
using System.Collections.Generic;

namespace RenderDesignWeb.Models.Implementation
{
    public class DesignerRepository : IDesignerRepository
    {
        public List<Designer> GetDesigner()
        {
            throw new System.NotImplementedException();
        }

        public Designer Login(string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public Designer Register(Designer designer)
        {
            throw new System.NotImplementedException();
        }
    }
}
