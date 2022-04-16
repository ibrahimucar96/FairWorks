using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class GorusulenFirma:BaseEntitiy
    {
        public int PersonelId { get; set; }
        public Personel PersonelAdı { get; set; }
        public DateTime GorusmeTarihi { get; set; }
        public string GorusulenKisi { get; set; }
        public string Unvanı { get; set; }
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }       
        public string FirmanınSektoru { get; set; }
        public string FirmaninProfili { get; set; }
        public string Distributor { get; set; }
        public string Diger { get; set; }
        public string FirmaninIlgilendigiFuar { get; set; }
        public string FirmaninIlgilendigiSalon { get; set; }
        public string GorusmeNotlari { get; set; }

    }
}
