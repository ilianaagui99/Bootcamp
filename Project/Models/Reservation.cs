using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Reservation
        {
                [Key]
                public int ReservationId { get; set; }

                [Required]
                [MinLength(2)]
                public string EventType {get; set;}

                [Required]
                [MinLength(2)]
                public string Description {get; set;}

                [Required]
                public DateTime date {get; set;} 

                [Required]
                public string address {get; set;}
                public DateTime CreatedAt {get; set;} = DateTime.Now;
                public DateTime UpdatedAt {get; set;} = DateTime.Now;

                //to keep track of guests
                public int UserId {get;set;}
                //to know who created this wedding
                public User Customer {get;set;}

                //photo gallery
               // public List<Association> UsersWhoRSVP{ get; set; }


        }
}