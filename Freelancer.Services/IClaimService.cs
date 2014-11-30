using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public interface IClaimService : IDisposable
    {
        void CreateClaim(claim c);
        void PostClaim(string title, string contenu, string email);
        bool test(int id,String email);
        IEnumerable<claim> GetClaims();
        IEnumerable<user> getusers();






    }
}
