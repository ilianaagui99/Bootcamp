using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
    {
        public class Form
            {
                [Required]
                [MinLength(1)]
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