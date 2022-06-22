using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class TemsilEttigiFirmaDto
    {
        [Key]
        public int TemsilEttigiFirmaId { get; set; }
        [Required(ErrorMessage = "Temsil Edilen Firma Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string TemsilEdilenFirma { get; set; }
        [Required(ErrorMessage = "Ulke Alani Boş Olamaz.")]
        [MaxLength(20)]
        public string Ulke { get; set; }
        [Required(ErrorMessage = "Temsil Edilen Firma Urunleri Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string TemsilEdilenFirmaUrunleri { get; set; }
        [Required(ErrorMessage = "Iletisim Bilgileri Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string IletisimBilgileri { get; set; }
    }
}
