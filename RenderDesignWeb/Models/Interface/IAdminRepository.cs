namespace RenderDesignWeb.Models.Interface
{
    public interface IAdminRepository
    {
        Admin Login(string email, string password);
    }
}
