using System.ComponentModel.DataAnnotations;

namespace EFConnect.Models.User
{
    public class UserForRegister
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must be between 8 characters.")]
        public string Password { get; set; }
    }
}