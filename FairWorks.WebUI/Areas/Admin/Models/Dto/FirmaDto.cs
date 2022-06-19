using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class FirmaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Firma Adi Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string FirmaAd { get; set; }
        [Required(ErrorMessage = "Adres Alani Boş Olamaz.")]
        [MaxLength(100)]
        public string Adres { get; set; }
        [Phone(ErrorMessage = "Telefon Alani Boş Olamaz.")]
        [MaxLength(20)]
        public string Telefon { get; set; }
        [EmailAddress(ErrorMessage = "Eposta Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Eposta { get; set; }
        public string Faks { get; set; }
        [Required(ErrorMessage = "Sehir Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Ulke Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Ulke { get; set; }
    }
}
