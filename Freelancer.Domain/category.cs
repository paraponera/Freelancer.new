using System;
using System.Collections.Generic;

namespace Freelancer.Domain
{
    public partial class category
    {
        public category()
        {
            this.jobs = new List<job>();
            this.sous_categories = new List<sous_categories>();
        }

        public int id_Ca { get; set; }
        public string name { get; set; }
        public virtual ICollection<job> jobs { get; set; }
        public virtual ICollection<sous_categories> sous_categories { get; set; }
    }
}
