using System.Collections.Generic;

namespace RenderDesignWeb.Models.Interface
{
    public interface IImageRepository
    {
        Image GetImg(int Id);
        List<Image> GetImages();
        List<Image> GetImages(int ProjectId);
        Image Add(Image image);
        void Update(Image image);
        void Delete(Image image);
    }
}
