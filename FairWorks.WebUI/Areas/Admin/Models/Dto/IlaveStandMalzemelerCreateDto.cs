using FairWorks.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class IlaveStandMalzemelerCreateDto
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
