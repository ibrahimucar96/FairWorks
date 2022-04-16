using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Personel:BaseEntitiy
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
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
        public string? PhotoPath { get; set; }
        public decimal Maas { get; set; }
        public ICollection<GorusulenFirma> GorusulenFirmalar { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
    }
}
