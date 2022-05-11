using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class FirmaTipi:BaseEntitiy
    {
        public int FirmaTipId { get; set; }
        public string FirmaTip { get; set; }
       

        public ICollection<FirmaTipveFirma> FirmaTipveFirmalar { get; set; }



    }
}
