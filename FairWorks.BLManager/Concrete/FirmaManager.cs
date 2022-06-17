using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Concrete
{
    public class FirmaManager : ManagerBase<Firma>, IFirmaManager
    {
        public bool CheckForFirmaAdi(string firmaAdi)
        {
            //tekrarlı kayıt girmeyi engelledik.
            var entities = base.db.GetAll(x => x.FirmaAd == firmaAdi);
            if (entities.Count > 0)
                return true;
            else
                return false;
        }
    }
}
