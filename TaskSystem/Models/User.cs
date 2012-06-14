using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string IconUrl { get; set; }
        public bool IsAdmin { get; set; }
    }
}