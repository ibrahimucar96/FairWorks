using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class KatalogGirisForm
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Faks { get; set; }
        public int UrunId { get; set; }
        public Urun UrunGrupları { get; set; }
        public int FirmaTipId { get; set; }
        public int TemsilEttigiFirmaId { get; set; }
        public FirmaTipveTemsilEdilenFirma FirmaTipveTemsilEdilenFirmalar { get; set; }

    }
}
