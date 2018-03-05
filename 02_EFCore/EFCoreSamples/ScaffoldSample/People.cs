using System;
using System.Collections.Generic;

namespace ScaffoldSample
{
    public partial class People
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string CompanyAddressLineOne { get; set; }
        public string CompanyAddressLineTwo { get; set; }
        public string BusinessCity { get; set; }
        public string BusinessCountry { get; set; }

        public Addr Addr { get; set; }
    }
}
