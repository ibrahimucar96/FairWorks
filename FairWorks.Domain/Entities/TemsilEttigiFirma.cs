﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class TemsilEttigiFirma:BaseEntitiy
    {
        public int TemsilEttigiFirmaId { get; set; }
        public string TemsilEdilenFirma { get; set; }
        public string Ulke { get; set; }
        public string TemsilEdilenFirmaUrunleri { get; set; }
        public string IletisimBilgileri { get; set; }
        
        public ICollection<FirmaTipveFirma> FirmaTipveFirmalar { get; set; }

    }
}