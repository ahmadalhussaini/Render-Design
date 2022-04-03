using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IDesignerRepository
    {
        Designer Register(Designer designer);
        Designer Login(string email, string password);
        List<Designer> GetDesigner();
        Project GetPDesigner(int Id);
        void Update(Designer designer);
        void Delete(Designer designer);


    }
}
