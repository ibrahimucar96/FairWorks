using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class FirmaBilgiCreateDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adres Alani Boş Olamaz.")]
        [MaxLength(255)]
        public string Adres { get; set; }
        [Phone(ErrorMessage = "Telefon Alani Boş Olamaz.")]
        [MaxLength(20)]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Vergi Dairesi Alani Boş Olamaz.")]
        [MaxLength(100)]
        public string VergiDairesi { get; set; }
        [Required(ErrorMessage = "Vergi Numarasi Alani Boş Olamaz.")]
        [MaxLength(10)]
        public string VergiNumarası { get; set; }
        [Required(ErrorMessage = "Fuar Yetkilisi Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string FuarYetkilisi { get; set; }
        public int UcretsizVerilenAlanId { get; set; }
        public UcretsizVerilenAlan UcretsizVerilenAlanlar { get; set; }
        
    }
}
