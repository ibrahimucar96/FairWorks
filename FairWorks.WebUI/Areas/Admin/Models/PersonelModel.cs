using System;

namespace FairWorks.WebUI.Areas.Admin.Models
{
    public class PersonelModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Unvan { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public byte[] Fotograf { get; set; }
        public string Notlar { get; set; }
        public string RaporVerdigiKisi { get; set; }
        public string PhotoPath { get; set; }
        public decimal Maas { get; set; }
    }
}
