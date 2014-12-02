using Freelancer.Data.Infrastructure;
using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
   public class UsersServices : IUsersServices
    {

        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public UsersServices()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }


        public void AddService(user o)
        {
            utOfWork.UserRepository.Add(o);
            utOfWork.Commit();
        }



        public void UpdateUser(user o)
        {
            utOfWork.UserRepository.Update(o);
            utOfWork.Commit();
        }

        public user getUserbyid(int id)
        {
            var off = utOfWork.UserRepository.GetById(id);
            return off;
        }

        public int Authentification(String login, String pwd)
        {
            if (utOfWork.UserRepository.GetMany(x => x.e_mail.Equals(login) && x.pwd.Equals(pwd)).ToList().Count == 1)
            {
                return 0;
            }

            else return -1;
        }
        public int FindByEmail(string email)
        {
            user u = utOfWork.UserRepository.Get(x => x.e_mail.Equals(email));
            return u.id;
        }
        public statistique statistique()
        {
            statistique s = new statistique();
            s.nbrFreelancer = utOfWork.UserRepository.GetMany(u => u.DTYPE.Equals("freelancer")).Count();
            s.nbrJobOwner = utOfWork.UserRepository.GetMany(u => u.DTYPE.Equals("jobowner")).Count();
            return s;
        }


        public void Dispose()
        {
            utOfWork.Dispose();
        }


    }
}
