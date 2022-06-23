using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class FirmaTipi
    {
        [Key]
        public int FirmaTipId { get; set; }
       
        public string FirmaTip { get; set; }


        public ICollection<KatalogGirisForm> KatalogGirisForms { get; set; }
        public ICollection<FirmaTipveTemsilEdilenFirma> TemsilEttigiFirmalar { get; set; }



    }
}
