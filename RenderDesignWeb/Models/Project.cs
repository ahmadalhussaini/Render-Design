using System.Collections.Generic;

namespace RenderDesignWeb.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public List<Image> Images { set; get; }

        public Designer Designer { get; set; }

        public int? DesignerId { set; get; }
    }
}
