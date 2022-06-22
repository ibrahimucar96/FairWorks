using FairWorks.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class GorusulenFirmaCreateDto
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public Personel PersonelAdı { get; set; }
        [Required(ErrorMessage = "Gorusme Tarihi Alani Boş Olamaz.")]
        [MaxLength(20)]        
        public string GorusmeTarihi { get; set; }
        [Required(ErrorMessage = "Gorusulen Kisi Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string GorusulenKisi { get; set; }
        [Required(ErrorMessage = "Unvani Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Unvanı { get; set; }
        [Required(ErrorMessage = "Telefon Alani Boş Olamaz.")]
        [MaxLength(20)]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Eposta Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string Eposta { get; set; }
        [Required(ErrorMessage = "Firmanin Calistigi Alan Boş Olamaz.")]
        [MaxLength(50)]
        public string FirmanınCalıstıgıSektoru { get; set; }
        [Required(ErrorMessage = "Firmanin Profili Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string FirmaninProfili { get; set; }
        [Required(ErrorMessage = "Firmanin Ilgilendigi Fuar Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string FirmaninIlgilendigiFuar { get; set; }
        [Required(ErrorMessage = "Firmanin Ilgilendigi Salon Alani Boş Olamaz.")]
        [MaxLength(50)]
        public string FirmaninIlgilendigiSalon { get; set; }
        public string GorusmeNotlari { get; set; }
    }
}
