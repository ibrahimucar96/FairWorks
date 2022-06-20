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

        public bool TcDogrula(string tcno)
        {
            bool returnvalue = false;
            if (tcno.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tcno);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }
            return returnvalue;
        }
    }
}
