using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı adı giriniz.")]
        public string? UserName { get; set; } 
        [Required(ErrorMessage ="Şifrenizi giriniz.")]
        public string? Password { get; set; }
    }
}
