using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    public interface IRepository<P> where P : class
    {
        void Add(P entity);
        void Update(P entity);
        void Delete(int id);
        void Delete(string id);
        void Delete(Expression<Func<P, bool>> where);
        P GetById(int id);
        P GetById(string id);
        P Get(Expression<Func<P, bool>> where);
        IEnumerable<P> GetAll();
        IEnumerable<P> GetMany(Expression<Func<P, bool>> where);
    }
}
