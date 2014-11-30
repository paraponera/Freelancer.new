using System;
using System.Collections.Generic;

namespace Freelancer.Domain
{
    public partial class claim
    {
        public int id { get; set; }
        public string contenu { get; set; }
        public string email { get; set; }
        public string state { get; set; }
        public string title { get; set; }
    }
}
