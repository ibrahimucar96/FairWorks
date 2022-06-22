using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class IlaveStandMalzemeler
    {
        public int Id { get; set; }

        
        public string IlaveStandMalzemesi { get; set; }
        public int MalzemeKodu { get; set; }
        public string MalzemeAdı { get; set; }
        public string ElektrikKw { get; set; }
        public decimal Fiyat { get; set; }
        public string Ozellik { get; set; }
        public int TedarikciId { get; set; }
        public Tedarikci Tedarikciler { get; set; }

    }
}
