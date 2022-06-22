using FairWorks.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class IlaveStandMalzemelerCreateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ilave Stand Malzemesi Alani Boş Olamaz.")]
        [MaxLength(100)]
        public string IlaveStandMalzemesi { get; set; }
        [Required(ErrorMessage = "Malzeme Kodu Alani Boş Olamaz.")]
        [MaxLength(50)]
        public int MalzemeKodu { get; set; }
        [Required(ErrorMessage = "Malzeme Adi Alani Boş Olamaz.")]
        [MaxLength(100)]
        public string MalzemeAdı { get; set; }
        [Required(ErrorMessage = "Elektrik Kw Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string ElektrikKw { get; set; }
        [Required(ErrorMessage = "Fiyat Alani Boş Olamaz.")]
        [MaxLength(50)]
        public decimal Fiyat { get; set; }
        [Required(ErrorMessage = "Ozellik Alani Boş Olamaz.")]
        [MaxLength(100)]
        public string Ozellik { get; set; }
        public int TedarikciId { get; set; }
        public Tedarikci Tedarikciler { get; set; }
    }
}
