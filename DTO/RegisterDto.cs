using System.ComponentModel.DataAnnotations;

namespace Day1of_WenApi.DTO
{
    public class RegisterDto
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string confirmpassword { get; set; }

        [Required]
        public string email { get; set; }
    }
}
