using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Freelancer.Domain
{
    public partial class claim
    {
        public int id { get; set; }

        [Required(ErrorMessage = "**Required.")]
        public string contenu { get; set; }
         
        public string email { get; set; }
        public string state { get; set; }

        [Required(ErrorMessage = "**Required.")]
        public string title { get; set; }
    }
}
