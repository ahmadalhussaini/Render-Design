using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
    public class PostRepository : IPostRepository
    {
        readonly RenderDesignContext db;
        public PostRepository(RenderDesignContext db)
        {
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.db = db;
        }
        public Post Add(Post entity)
        {
            var post = db.Posts.Add(entity);
            db.SaveChanges();
            return post.Entity;
        }

        public void Delete(Post entity)
        {
            db.Posts.Remove(entity);
            db.SaveChanges();
        }

        public Post GetPost(int Id)
        {
            var post = db.Posts.Where(x => x.Id == Id);
            return post;
        }

        public List<Post> GetPosts()
        {
            var post = db.Posts.ToList();
            return post;
        }
    }
}
