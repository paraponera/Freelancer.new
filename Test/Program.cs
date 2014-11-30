using Freelancer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaimService A = new ClaimService();
            A.PostClaim("tutil ", "ji swi in onfent", "soubitex@soubya.nbi3");

        }
    }
}
