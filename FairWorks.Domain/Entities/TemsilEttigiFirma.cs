using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class TemsilEttigiFirma
    {
        [Key]
        public int TemsilEttigiFirmaId { get; set; }

        public string TemsilEdilenFirma { get; set; }
        public string Ulke { get; set; }
        public string TemsilEdilenFirmaUrunleri { get; set; }
        public string IletisimBilgileri { get; set; }

        public ICollection<KatalogGirisForm> KatalogGirisForms { get; set; }
        public ICollection<FirmaTipveTemsilEdilenFirma> FirmaTipi { get; set; }
    }
}
