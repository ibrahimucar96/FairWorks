using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class KatalogGirisForm:BaseEntitiy
    {
        public Firma Firma { get; set; }
        public Urun UrunGrupları { get; set; }
        public FirmaTipi FirmaTip { get; set; }
    }
}
