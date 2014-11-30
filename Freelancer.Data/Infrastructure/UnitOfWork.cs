using Freelancer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        IDatabaseFactory dbFactory;
        pidevContext dataContext;

        public pidevContext DataContext
        {
            get { return dataContext = dbFactory.DataContext; }
        }


        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }

        private IUserRepository userRepository;
        public IUserRepository UserRepository
        {
            get { return userRepository = new UserRepository(dbFactory); }
        }

        private IJobRepository jobRepository;
        public IJobRepository JobRepository
        {
            get { return jobRepository = new JobRepository(dbFactory); }
        }


        private IBankRepository bankRepository;
        public IBankRepository BankRepository
        {
            get { return bankRepository = new BankRepository(dbFactory); }
        }

        private IClaimRepository claimRepository;
        public IClaimRepository ClaimRepository
        {
            get { return claimRepository = new ClaimRepository(dbFactory); }
        }
        private ICategoryRepository categoryRepository;
        public ICategoryRepository CategoryRepository
        {
            get { return categoryRepository = new CategoryRepository(dbFactory); }
        }

        private ISouscategoryRepository souscategoryRepository;
        public ISouscategoryRepository SouscategoryRepository
        {
            get { return souscategoryRepository = new SouscategoryRepository(dbFactory); }
        }

        private IPaymentRepository paymentRepository;
        public IPaymentRepository PaymentRepository
        {
            get { return paymentRepository = new PaymentRepository(dbFactory); }
        }

        private IFriendslistRepository friendslistRepository;
        public IFriendslistRepository FriendslistRepository
        {
            get { return friendslistRepository = new FriendsListRepository(dbFactory); }
        }
        public void Dispose()
        {
            dbFactory.Dispose();
        }



    }
}
