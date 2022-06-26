﻿using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class LoginCreateDto
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Kullanici Adi Bos Olamaz")]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Sifre Alani Bos Olamaz")]

        public string Password { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Sifre Alani Bos Olamaz")]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Alani Bos Olamaz")]
        [MaxLength(50)]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
