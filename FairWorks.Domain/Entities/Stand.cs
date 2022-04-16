using System.Collections;
using System.Collections.Generic;

namespace FairWorks.Domain.Entities
{
    public class Stand:BaseEntitiy
    {
        public string StandTipi { get; set; }
        public int StandKodu { get; set; }
        public ICollection<TeklifBilgisi> TeklifBilgileri { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
        public int SalonId { get; set; }
        public Salon Salonlar { get; set; }
    }
}