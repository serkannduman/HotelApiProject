using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servis ikon linki giriniz")]
        public string? ServiceIcon { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir")]
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
