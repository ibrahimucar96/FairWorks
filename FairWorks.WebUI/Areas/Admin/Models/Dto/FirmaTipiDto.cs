using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class FirmaTipiDto
    {
        public int FirmaTipId { get; set; }
        [Required(ErrorMessage = "Firma Tipi Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string FirmaTip { get; set; }
    }
}
