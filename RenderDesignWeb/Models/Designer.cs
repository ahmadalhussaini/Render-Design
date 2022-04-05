﻿using System;

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
        public object Project { get; internal set; }
    }
}
