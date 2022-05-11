using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class PotansiyelFirma:BaseEntitiy
    {
        public int PotansiyelFirmaId { get; set; }
        public int FirmaId { get; set; }
        public Firma  Firma { get; set; }
        public string Yetkili { get; set; }
        public string Unvani { get; set; }       
        public string DahiliTelefon { get; set; }
        public string DirektTelefon { get; set; }                            
        public string Sektor { get; set; }
    }
}
