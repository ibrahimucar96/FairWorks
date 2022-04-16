using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Doviz:BaseEntitiy
    {
        public string DovizCinsi { get; set; }
        public decimal DovizKuru { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
        public ICollection<TeklifBilgisi> TeklifBilgileri { get; set; }
    }
}
