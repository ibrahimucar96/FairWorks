﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class SozlesmeBilgisi:BaseEntitiy
    {
        public int SozlesmeBilgisiId { get; set; }
        public DateTime SozlesmeTarihi { get; set; }
        public int PersonelId { get; set; }
        public Personel PersonelAdi { get; set; }
        public int FirmaId { get; set; }
        public Firma FirmaBilgileri { get; set; }
        public int SozlesmeTipiId { get; set; }
        public SozlesmeTipi SozlesmeTipleri { get; set; }
        public int StandId { get; set; }
        public Stand Stand { get; set; }
        public int OdemePlaniId { get; set; }
        public OdemePlani OdemePlani { get; set; }
        public int DovizId { get; set; }
        public Doviz   Doviz { get; set; }                      
        public DateTime SozlesmeSonGecerlilikTarihi { get; set; }
        public bool ImzaliSozlesmeDurumu { get; set; }
        public int salonId { get; set; }
        public Salon Salon { get; set; }

    }
}
