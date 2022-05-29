using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class SozlesmeTipi
    {
        public int Id { get; set; }

        public string SozlesmeTipleri { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
    }
}
