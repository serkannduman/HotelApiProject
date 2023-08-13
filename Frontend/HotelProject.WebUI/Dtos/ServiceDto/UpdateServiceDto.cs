using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servis ikon linki giriniz")]
        public string? ServiceIcon { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string? Title { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir")]
        public string? Description { get; set; }
    }
}
