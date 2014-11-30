using System;
using System.Collections.Generic;

namespace Freelancer.Domain
{
    public partial class user
    {
        public string DTYPE { get; set; }
        public int id { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string e_mail { get; set; }
        public string first_name { get; set; }
        public float fund { get; set; }
        public string last_name { get; set; }
        public byte[] picture { get; set; }
        public string pwd { get; set; }
        public bool state { get; set; }
        public string type { get; set; }
        public string username { get; set; }
        public string about { get; set; }
        public string cv { get; set; }
        public string friend_list { get; set; }
        public string skills { get; set; }
        public string company_name { get; set; }
    }
}
