using System.ComponentModel.DataAnnotations;

namespace DoAn3.Dto.Cart
{
    public class CreateCart
    {

        [Required]
        public int IdUSer { get; set; }
        [Required]
        public int IdOrder { get; set; }
    }
}
