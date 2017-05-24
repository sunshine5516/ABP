using System.ComponentModel.DataAnnotations;

namespace ABPFramework.Api.Models
{
    public class LoginModel
    {
        public string TenancyName { get; set; }

        [Required]
        public string UsernameOrEmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}