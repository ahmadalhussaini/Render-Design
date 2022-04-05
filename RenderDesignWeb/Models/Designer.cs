using System;
using System.Collections.Generic;

namespace RenderDesignWeb.Models
{
    public class Designer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; }
        public virtual List<Project> Projects { get; set; }
    }
}
