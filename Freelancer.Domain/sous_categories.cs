using System;
using System.Collections.Generic;

namespace Freelancer.Domain
{
    public partial class sous_categories
    {
        public int id_Sc { get; set; }
        public string name { get; set; }
        public Nullable<int> Id_Ca { get; set; }
        public virtual category category { get; set; }
    }
}
