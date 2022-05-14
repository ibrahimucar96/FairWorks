using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Concrete
{
    public class PersonelManager:ManagerBase<Personel>, IPersonelManager
    {
        public bool CheckForTcNo(string tcno)
        {
            bool sonuc = true;

            if (tcno.Length != 11)
                throw new Exception($"{tcno} TC Kimlik Numarasi 11 Karakter Olmalidir.");
            foreach (char item in tcno)
            {
                if (char.IsDigit(item))
                    throw new Exception($"{tcno} TC Kimlik Numarasi Sayilardan Olusmalidir");
                
            }
            var personel = base.db.GetAll(x=> x.TcNo == tcno).FirstOrDefault();
            if (personel != null)
                throw new Exception($"{tcno} TC Kimlik Numarasi Daha Onceden Kaydedilmistir");
            sonuc = false;
            return sonuc;
        }
        public bool CheckForGsm(string gsm)
        {
            var personel = base.db.GetAll(x=> x.Telefon == gsm).FirstOrDefault();
            if (personel != null)
            {
                throw new Exception($"{gsm} Telefon Numarası Daha Onceden Kaydedilmistir");

            }
            return false;
        }


    }
}
