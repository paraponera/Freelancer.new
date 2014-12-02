using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Domain
{
    public partial class apply
    {
        public int id_Apply { get; set; }
        public int id_Freelancer { get; set; }
        public int id_Job { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
    }
}
