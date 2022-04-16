using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class SozlesmeTipi:BaseEntitiy
    {
        public string SozlesmeTipleri { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
    }
}
