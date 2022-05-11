using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class IlaveStandMalzemeler:BaseEntitiy
    {
        public int IlaveStandMalzemeId { get; set; }
        public string IlaveStandMalzemesi { get; set; }
        public int MalzemeKodu { get; set; }
        public string MalzemeleAdı { get; set; }
        public string ElektrikKw { get; set; }
        public decimal Fiyat { get; set; }
        public string Ozellik { get; set; }
        public ICollection<Tedarikci> Tedarikciler { get; set; }

    }
}
