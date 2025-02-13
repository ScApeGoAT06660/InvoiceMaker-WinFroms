﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaker.Domains
{
    public class Trader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual string VATID { get; set; }
        public string StreetAndNo { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
    }
}
