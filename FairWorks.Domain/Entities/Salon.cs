using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Salon:BaseEntitiy
    {
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public int SalonNo { get; set; }
        public string m2 { get; set; }
        public string en { get; set; }
        public string boy { get; set; }
        public string SektorAdi { get; set; }
        public ICollection<Stand> Standlar { get; set; }       
        public ICollection<SozlesmeBilgisi> SozlesmeliMusteriler { get; set; }
        public ICollection<TeklifBilgisi> TeklifBilgileri { get; set; }
    }
}
