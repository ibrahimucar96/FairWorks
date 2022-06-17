using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Concrete
{
    public class FirmaBilgiManager : ManagerBase<FirmaBilgi>, IFirmaBilgiManager
    {
        public bool CheckForVergiNo(string vergiNo)
        {
            var entities = base.db.GetAll(x => x.VergiNumarası == vergiNo);
            if (entities.Count > 0)
                return true;
            else
                return false;
        }
    }
}
