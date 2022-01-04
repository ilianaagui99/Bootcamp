using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProductsyCategories.Models
{
    public class Association
        {
            [Key]
            public int AssociationId { get; set; }
            public int ProductId {get; set;}
            public int CategoryId {get; set;}
            public Product Product {get; set;}
            public Category Category {get; set;}

        }
}