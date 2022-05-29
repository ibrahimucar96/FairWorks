using System.Collections;
using System.Collections.Generic;

namespace FairWorks.Domain.Entities
{
    public class Urun
    {
        public int Id { get; set; }

        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public int UrunKodu { get; set; }
        public string UrunBilgileri { get; set; }
        public ICollection<KatalogGirisForm> KatalogGirisForm { get; set; }
    }
}