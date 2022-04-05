using Microsoft.EntityFrameworkCore;
using RenderDesignWeb.Context;
using RenderDesignWeb.Models.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RenderDesignWeb.Models.Implementation
{
    public class ImageRepository : IImageRepository
    {
        readonly RenderDesignContext db;
        public ImageRepository(RenderDesignContext db)
        {
            db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.db = db;
        }
        public Image Add(Image entity)
        {
            var image = db.Images.Add(entity);
            db.SaveChanges();
            return image.Entity;
        }

        public void Delete(Image entity)
        {
            db.Images.Remove(entity);
            db.SaveChanges();
        }

        public List<Image> GetImages()
        {
            var image = db.Images.ToList();
            return image;
        }

        public List<Image> GetImages(int ProjectId)
        {
            var image = db.Images.Where(x => x.ProjectId == ProjectId).ToList();
            return image;
        }

        public Image GetImg(int Id)
        {
            var image = db.Images.SingleOrDefault(x => x.Id == Id);
            return image;
        }

        public void Update(Image entity)
        {
            db.Images.Update(entity);
            db.SaveChanges();
        }
    }
}
