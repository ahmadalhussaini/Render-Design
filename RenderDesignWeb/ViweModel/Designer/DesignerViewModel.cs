using Microsoft.AspNetCore.Http;
using RenderDesignWeb.ViweModel.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderDesignWeb.ViweModel.Designer
{
    public class DesignerViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }
        public List<IFormFile> _project { get; set; }
       public List<ProjectViewModel> project { get; set; }
        public DateTime CreatedAt { get; set; }
       
    }
}
