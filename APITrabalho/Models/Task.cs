using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITrabalho.Models
{
     public class Task
    {
        public int Id { get; set; }

        public string Task { get; set; }

        public string? Task_Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public string Priority { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string UserId { get; set; }
    }
}