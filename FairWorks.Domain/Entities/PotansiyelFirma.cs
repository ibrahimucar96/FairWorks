using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class PotansiyelFirma
    {
        public int Id { get; set; }

        public string FirmaAdı { get; set; }
        public string Yetkili { get; set; }
        public string Unvani { get; set; }
        public string Telefon { get; set; }
        public string DahiliTelefon { get; set; }
        public string DirektTelefon { get; set; }
        public string Email { get; set; }
        public string Faks { get; set; }
        public string Adres { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Sektor { get; set; }
    }
}
