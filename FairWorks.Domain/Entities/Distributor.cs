﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Distributor:BaseEntitiy
    {
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
    }
}
