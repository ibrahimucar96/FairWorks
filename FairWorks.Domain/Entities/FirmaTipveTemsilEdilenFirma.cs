using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class FirmaTipveTemsilEdilenFirma
    {       
        [ForeignKey("TemsilEttigiFirma")]
        public int TemsilEttigiFirmaId { get; set; }
        [ForeignKey("FirmaTipi")]
        public int FirmaTipId { get; set; }

        public TemsilEttigiFirma TemsilEttigiFirma { get; set; }
        public FirmaTipi FirmaTipi { get; set; }

        
    }
}
