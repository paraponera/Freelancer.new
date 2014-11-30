using Freelancer.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    public class RepositoryBase<P> : IRepository<P> where P : class
    {
        private pidevContext dataContext;
        public pidevContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        private IDbSet<P> dbset;
        IDatabaseFactory dbFactory;
        public RepositoryBase(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            dbset = DataContext.Set<P>();
        }

        public virtual void Add(P entity)
        {
            dbset.Add(entity);
        }

        public virtual void Update(P entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(int id)
        {
            var e = dbset.Find(id);
            dbset.Remove(e);
        }

        public virtual void Delete(string id)
        {
            var e = dbset.Find(id);
            dbset.Remove(e);
        }

        public virtual void Delete(System.Linq.Expressions.Expression<Func<P, bool>> where)
        {
            IEnumerable<P> entities = dbset.Where(where);
            foreach (P e in entities)
            {
                dbset.Remove(e);
            }
        }

        public virtual P GetById(int id)
        {
            return dbset.Find(id);
        }

        public virtual P GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual P Get(System.Linq.Expressions.Expression<Func<P, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault();
        }

        public virtual IEnumerable<P> GetAll()
        {
            return dbset.AsEnumerable();
        }

        public virtual IEnumerable<P> GetMany(System.Linq.Expressions.Expression<Func<P, bool>> where)
        {
            return dbset.Where(where).AsEnumerable();
        }
    }
}
