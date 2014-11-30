using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    class SouscategoryRepository: RepositoryBase<sous_categories>, ISouscategoryRepository
    {
        public SouscategoryRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }


    public interface ISouscategoryRepository : IRepository<sous_categories>
    {
    }
}
