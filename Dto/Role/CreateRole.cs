using System.ComponentModel.DataAnnotations;

namespace DoAn3.Dto.Role
{
    public class CreateRole
    {
        private string _name;
        [Required]
        public string Name
        {
            get => _name;
            set => _name = value?.Trim();
        }
    }
}
