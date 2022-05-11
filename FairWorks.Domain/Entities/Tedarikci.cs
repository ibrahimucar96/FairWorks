using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Tedarikci:BaseEntitiy
    {
        public int TedarikciId { get; set; }
        public string Tedarikciler { get; set; }

        public IlaveStandMalzemeler İlaveStandMalzemeleri { get; set; }

    }
}
