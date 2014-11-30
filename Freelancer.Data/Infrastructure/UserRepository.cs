using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    class UserRepository: RepositoryBase<user>, IUserRepository
    {
        public UserRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }


    public interface IUserRepository : IRepository<user>
    {
    }
}
