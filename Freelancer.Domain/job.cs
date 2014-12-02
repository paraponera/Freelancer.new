using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Freelancer.Domain
{
    public partial class job
    {
        public int id { get; set; }

        [Display(Name = "Price")]
        public float cost { get; set; }
        
        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Estimation")]
        public int estimate_duration { get; set; }
        public int jobownerid { get; set; }

        [Display(Name = "Skills")]
        public string required_skills { get; set; }
        public string state { get; set; }

        [Display(Name = "Title")]
        public string title { get; set; }
        public int userid { get; set; }
        public Nullable<int> categ_fk { get; set; }
        public virtual category category { get; set; }
    }
}
