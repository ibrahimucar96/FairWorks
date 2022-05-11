using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class OdemePlani:BaseEntitiy
    {
        public int OdemePlaniId { get; set; }
        public decimal VadeSayisi { get; set; }
        public int Taksit { get; set; }
        public decimal Faiz { get; set; }
        public string Ay { get; set; }
        public string Yıl { get; set; }
        public decimal m2BirimFiyati { get; set; }
        public decimal m2 { get; set; }
        public decimal indirimOrani { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
        public ICollection<TeklifBilgisi> TeklifBilgileri { get; set; }

    }
}
