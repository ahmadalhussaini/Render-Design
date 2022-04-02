using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IDesignerRepository
    {
        Designer Register(Designer designer);

        Designer Login(string email, string password);

        List<Designer> GetDesigner();
    }
}
