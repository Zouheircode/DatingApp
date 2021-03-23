using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;


namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}