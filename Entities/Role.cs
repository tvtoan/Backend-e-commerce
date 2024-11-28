using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAn3.Entities
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRole { get; set; }
       
        [Required]
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

       
        
    }
}
