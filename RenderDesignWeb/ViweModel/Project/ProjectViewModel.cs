using Microsoft.AspNetCore.Http;
using RenderDesignWeb.ViweModel.Designer;
using RenderDesignWeb.ViweModel.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.ViweModel.Project
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int? DesignerId { set; get; }
        public string Type { get; set; }
        public List<IFormFile> _images { get; set; }
        public string FirstImage { get; set; }

        public List<ImageViewModel> images { get; set; }

    }
}
