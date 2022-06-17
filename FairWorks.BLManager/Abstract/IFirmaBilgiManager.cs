using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Abstract
{
    public interface IFirmaBilgiManager:IManagerBase<FirmaBilgi>
    {
        public bool CheckForVergiNo(string vergiNo);
    }
}
