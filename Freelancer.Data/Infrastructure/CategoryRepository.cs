using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    class CategoryRepository: RepositoryBase<category>, ICategoryRepository
    {
        public CategoryRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }


    public interface ICategoryRepository : IRepository<category>
    {
    }
}
