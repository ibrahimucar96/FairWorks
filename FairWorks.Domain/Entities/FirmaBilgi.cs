using System.Collections;
using System.Collections.Generic;

namespace FairWorks.Domain.Entities
{
    public class FirmaBilgi
    {
        public int Id { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNumarası { get; set; }
        public string FuarYetkilisi { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgisi { get; set; }
    }
}