using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class DavetiyesizZiyaretci:BaseEntitiy
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }             
        public string Meslek { get; set; }

    }
}
