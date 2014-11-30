using System;
using System.Collections.Generic;

namespace Freelancer.Domain
{
    public partial class payment
    {
        public int id { get; set; }
        public Nullable<double> compte { get; set; }
        public int idfreelancer { get; set; }
        public int idjobowner { get; set; }
        public Nullable<float> solde { get; set; }
    }
}
