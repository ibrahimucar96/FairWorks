using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class KatalogGirisForm
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
        public int UrunId { get; set; }
        public Urun UrunGrupları { get; set; }
        public int FirmaTipId { get; set; }
        public FirmaTipi FirmaTip { get; set; }

    }
}
