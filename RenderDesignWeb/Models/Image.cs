using System;

namespace RenderDesignWeb.Models
{
    public class Image
    {
        public int Id { set; get; }


        public Project Project { set; get; }

        public int? ProjectId { set; get; }

        public string PathImg { set; get; }

        
    }
}
