using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class DavetiyesizZiyaretciDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "SoyAd Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string SoyAd { get; set; }
        [Required(ErrorMessage = "Firma Adi Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string FirmaAdı { get; set; }
        [Phone(ErrorMessage = "Telefon Alani Boş Olamaz.")]
        [MaxLength(20)]
        public string Telefon { get; set; }
        [EmailAddress(ErrorMessage = "Email Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Eposta { get; set; }
        public string Faks { get; set; }
        [Required(ErrorMessage = "Meslek Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Meslek { get; set; }
    }
}
