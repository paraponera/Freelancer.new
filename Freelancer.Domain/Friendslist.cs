using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Domain
{
    public partial class Friendslist
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public int idFriend { get; set; }
        public Boolean friend { get; set; }
        public Boolean request { get; set; }


    }
}
