using System.ComponentModel.DataAnnotations;

namespace BizLand.DTOs
{
    public class LoginDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string UserNameOrEmail { get; set; }
        [Required]
        [MinLength(7)]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
    }
}
