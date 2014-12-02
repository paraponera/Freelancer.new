using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Freelancer.Domain
{
    public partial class user
    {
        public string DTYPE { get; set; }
        public int id { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "Country")]
        public string country { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required.")]
        public string e_mail { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name")]
        public string first_name { get; set; }
        public float fund { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        [Display(Name = "Surname")]
        public string last_name { get; set; }
        public byte[] picture { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required.")]
        public string pwd { get; set; }
        public bool state { get; set; }
        public string type { get; set; }
        public string username { get; set; }
        public string about { get; set; }
        public string cv { get; set; }
        public string friend_list { get; set; }

        [Display(Name = "Skills")]
        public string skills { get; set; }

        [Display(Name = "Company name")]
        public string company_name { get; set; }
    }
}
