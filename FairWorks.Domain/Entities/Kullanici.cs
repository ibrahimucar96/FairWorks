﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class Kullanici:BaseEntitiy
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime LoginDate { get; set; }
    }
}
