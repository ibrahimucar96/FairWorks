using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Abstract
{
    public interface IPersonelManager:IManagerBase<Personel>
    {
        public bool CheckForTcNo(string tcno);
        public bool CheckForGsm(string gsm);
        public bool TcDogrula(string tcno);
    }
}
