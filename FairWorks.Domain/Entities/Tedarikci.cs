using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Tedarikci
    {
        public int Id { get; set; }

        public string Tedarikciler { get; set; }

        public ICollection<IlaveStandMalzemeler> IlaveStandMalzemeleri { get; set; }

    }
}
