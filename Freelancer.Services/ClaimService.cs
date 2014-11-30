using Freelancer.Data.Infrastructure;
using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public class ClaimService : IClaimService
    {
        IDatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public ClaimService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }
        public void CreateClaim(claim c)
        {
            utOfWork.ClaimRepository.Add(c);
            utOfWork.Commit();
        }
        public void PostClaim(string title, string contenu, string email)
        {
            //var offers = utOfWork.OfferRepository.GetAll();
            //return offers;
            claim claim1 = new claim
            {
                title = title,
              email = email,
                contenu = contenu
            };
            utOfWork.ClaimRepository.Add(claim1);
            utOfWork.Commit();

        }

        public IEnumerable<claim> GetClaims()
        {
            return utOfWork.ClaimRepository.GetAll();
        }

        public IEnumerable<user> getusers()
        {
            return utOfWork.UserRepository.GetAll();
        }

        public bool test(int id,String email){
        
            user user = utOfWork.UserRepository.Get(p => p.e_mail == email);
            if (user == null)
            {
                return false;

            }
            else
            {
                Friendslist Friendslist = new Friendslist
                {
                    idUser = id,
                    idFriend = user.id,
                    friend = false,
                    request = true


                };
                utOfWork.FriendslistRepository.Add(Friendslist);
                utOfWork.Commit();
                return true;
            }




        
        }



        public void Dispose()
        {
            utOfWork.Dispose();
        }
    }
}
