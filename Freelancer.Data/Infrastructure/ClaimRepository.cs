using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    public class ClaimRepository : RepositoryBase<claim>, IClaimRepository
    {
        public ClaimRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }


    public interface IClaimRepository : IRepository<claim>
    {
    }
}
