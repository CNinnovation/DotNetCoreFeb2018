using System;
using System.Collections.Generic;

namespace ScaffoldSample
{
    public partial class Addr
    {
        public int PersonId { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LocationCity { get; set; }
        public string LocationCountry { get; set; }

        public People Person { get; set; }
    }
}
