using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class UcretsizVerilenAlan
    {
        public int UcretsizVerilenAlanId { get; set; }       
        public string UcretsizVerilenm2 { get; set; }
        public ICollection<FirmaBilgi> FirmaBilgisi { get; set; }

    }
}
