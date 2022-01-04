using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Project.Models
{
    public class Association
    {
        //this is for likessss
        [Key]
        public int AssociationId { get; set; }
        [Required]
        public int PictureId { get; set; }
        public Picture picture { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}