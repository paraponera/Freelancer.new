using System;
using System.Collections.Generic;

namespace Freelancer.Domain
{
    public partial class job
    {
        public int id { get; set; }
        public float cost { get; set; }
        public string description { get; set; }
        public int estimate_duration { get; set; }
        public int jobownerid { get; set; }
        public string required_skills { get; set; }
        public string state { get; set; }
        public string title { get; set; }
        public int userid { get; set; }
        public Nullable<int> categ_fk { get; set; }
        public virtual category category { get; set; }
    }
}
