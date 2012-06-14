using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSystem.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public User Owner { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
    }
}