using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegistorDto
{
    public class CreateNewUserDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string?Name { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spyad alanı gereklidir.")]
        public string? Surname { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kullanıcı Adı alanı gereklidir.")]
        public string? UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mail alanı gereklidir.")]
        public string? Mail { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string? Password { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Şifre tekrar alanı gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string? ConfirmPassword { get; set; }
    }
}
