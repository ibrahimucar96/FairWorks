using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Concrete
{
    public class StandManager:ManagerBase<Stand>,IStandManager
    {
        public bool ChechForStandNo(int standno)
        {
            var stand = base.db.GetAll(x=> x.StandKodu == standno).FirstOrDefault();
            if (stand != null)
            {
                throw new Exception($"{standno} Bu Stand Numarası Doludur");
            }
            return false;
        }
    }
}
