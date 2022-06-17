﻿using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLManager.Abstract
{
    public interface IFirmaManager:IManagerBase<Firma>
    {
        public bool CheckForFirmaAdi(string firmaAdi);
    }
}
