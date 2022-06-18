using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Models.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Kullanici Adi Bos Olamaz")]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Sifre Alani Bos Olamaz")]
        [MaxLength(50)]
        public string Password { get; set; }
        public string Role { get; set; }
        public bool State { get; set; }

    }
}
