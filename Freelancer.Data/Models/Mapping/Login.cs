using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Models.Mapping
{
    public class Login
    {
        [Required()]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")]
        public string email { get; set; }
        [Required()]
        public string password { get; set; }
    }
}
