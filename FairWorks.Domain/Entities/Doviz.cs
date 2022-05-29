using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Doviz
    {
        public int Id { get; set; }
        public string DovizCinsi { get; set; }
        public decimal DovizKuru { get; set; }      
        public ICollection<TeklifBilgisi> TeklifBilgileri { get; set; }
    }
}
