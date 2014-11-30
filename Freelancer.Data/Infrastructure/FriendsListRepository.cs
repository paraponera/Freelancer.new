using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    class FriendsListRepository: RepositoryBase<Friendslist>, IFriendslistRepository
    {
        public FriendsListRepository(IDatabaseFactory dbFactory) : base(dbFactory) { }
    }


    public interface IFriendslistRepository : IRepository<Friendslist>
    {
    }
    
    
}
