using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class GorusulenFirma
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public Personel PersonelAdı { get; set; }
        public DateTime GorusmeTarihi { get; set; }
        public string GorusulenKisi { get; set; }
        public string Unvanı { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }            
        public string FirmanınCalıstıgıSektoru { get; set; }
        public string FirmaninProfili { get; set; }        
        public string FirmaninIlgilendigiFuar { get; set; }
        public string FirmaninIlgilendigiSalon { get; set; }
        public string GorusmeNotlari { get; set; }

    }
}
