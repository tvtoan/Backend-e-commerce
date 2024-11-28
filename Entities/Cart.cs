using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAn3.Entities
{
    public class Cart
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCart { get; set; }
        [Required]
        public int IdUser { get; set; }
        public User User { get; set; }
        [Required]
        public int IdProduct { get; set; }
        public Product Product { get; set; }
       
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }

    }
}
