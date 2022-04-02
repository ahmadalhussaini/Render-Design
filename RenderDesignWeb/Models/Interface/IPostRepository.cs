using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
        Post GetPost(int Id);
        Post Add(Post post);
        void Delete(Post post);
    }
}
