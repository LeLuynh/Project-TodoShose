using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class TodoModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsComplete { get; set; }
        
        [StringLength(100, MinimumLength = 5)]
        [Required]
        public string Description { get; set; }
    }
}
