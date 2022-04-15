using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IProjectRepository
    {
        List<Project> GetProjects();
        List<Project> GetProjects(string type);
        List<Project> ProjectsByDesigner(string designer);
        Project GetProject(int Id);
        Project Add(Project product);
        void Update(Project project);
        void Delete(Project project);
    }
}
