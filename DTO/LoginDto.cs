using System.ComponentModel.DataAnnotations;
  
namespace Day1of_WenApi.DTO
{
    public class LoginDto
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string password { get; set; }
    }
}
