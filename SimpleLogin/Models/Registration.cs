using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleLogin.Models
{
    public class Registration
        {
               [Required]
                [MinLength(2)]
                public string FirstName {get; set;}

                [Required]
                [MinLength(2)]
                public string LastName {get; set;}

                [Required]
                [Range(13,120)]
                public int Age {get; set;}

                [Required]
                [EmailAddress]
                public string Email {get; set;}

                [Required]
                [DataType(DataType.Password)]
                public string Password {get; set;}

        }
}