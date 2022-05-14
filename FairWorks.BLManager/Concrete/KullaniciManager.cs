using FairWorks.BLManager.Abstract;
using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Concrete
{
    public class KullaniciManager:ManagerBase<Kullanici>,IKullaniciManager
    {
        public bool CheckForUserName(string username)
        {
            var entities = base.db.GetAll(x=> x.UserName == username);
            if(entities.Count>0)
                return true;
            else
                return false;
        }
    }
}
