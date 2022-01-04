using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Picture 
        {
            [Key]  
            public int PictureId { get; set; }
            //[Required]
            public string Name { get; set; } 
            public int Likes{ get; set; }  
            
            public int userId {get;set;} //who uploaded pic

            [Required]
            [NotMapped]  
            public IFormFile Image {get;set;}
            public List<Association> usersWhoLikedThisPic { get; set; }  

        }
}