using Microsoft.AspNetCore.Http;
using RenderDesignWeb.ViweModel.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.ViweModel.Home
{
    public class HomeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public int? DesignerId { set; get; }
        public string FirstImage { get; set; }
        public List<IFormFile> _images { get; set; }
        public List<ImageViewModel> images { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
