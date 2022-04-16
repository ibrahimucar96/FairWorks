﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Firma:BaseEntitiy
    {
        public string FirmaAd { get; set; }       
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Faks { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
        public ICollection<BiletliZiyaretci> BiletliZiyaretciler { get; set; }
        public ICollection<DavetiyesizZiyaretci> DavetiyesizZiyaretciler { get; set; }
        public ICollection<GorusulenFirma> GorusulenFirmalar { get; set; }
        public ICollection<PotansiyelFirma> PotansiyelFirmalar { get; set; }
        public ICollection<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
        public ICollection<Ziyaretci> Ziyaretciler { get; set; }
        public ICollection<Distributor> Distributors { get; set; }

    }
}
