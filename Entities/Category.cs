﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAn3.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategory { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
