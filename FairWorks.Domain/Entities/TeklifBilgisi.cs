using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class TeklifBilgisi:BaseEntitiy
    {
        public int TeklifBilgisiId { get; set; }
        public DateTime TeklifTarihi { get; set; }
        public int StandId { get; set; }
        public Stand Stand { get; set; }
        public int DovizId { get; set; }
        public Doviz Doviz { get; set; }        
        public int OdemePlaniId { get; set; }
        public OdemePlani OdemePlani { get; set; }
        public DateTime TeklifinSonGecerlilikTarihi { get; set; }
        public int salonId { get; set; }
        public Salon Salon { get; set; }

    }
}
