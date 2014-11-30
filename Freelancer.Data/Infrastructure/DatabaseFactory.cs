using Freelancer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private pidevContext dataContext;
        public pidevContext DataContext
        {
            get { return dataContext; }
        }

        public DatabaseFactory()
        {
            dataContext = new pidevContext();
        }

        protected override void DisposeCore()
        {
            if (DataContext != null)
            {
                DataContext.Dispose();
            }
        }
    }
}
