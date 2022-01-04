using System;
using System.ComponentModel.DataAnnotations;
namespace Monster.Models
{
    public class Monstruo 
    {
        [Key]
        public int MonstruoId { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}