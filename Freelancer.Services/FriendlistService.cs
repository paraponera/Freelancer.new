using Freelancer.Data.Infrastructure;
using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public class FriendlistService:IFriendlistService
    {
        IDatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public FriendlistService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }

        public IEnumerable<user> listRequest(int idUser)
        {
            var testList = new List<user>();
          
            
            
            
            Friendslist[] req=new Friendslist[202];
           
            IEnumerable<Friendslist> friend = utOfWork.FriendslistRepository.GetMany(p => p.idFriend == idUser);
            
           
          
            
            foreach (Friendslist a in friend.ToList() ){

            if(a.request==true){

                testList.Add(utOfWork.UserRepository.Get(p => p.id == a.idUser));
              
            }else{

                

            }
            }
           
            return testList;
           
        }

        public void acceptfriend(int idfriend,int idUser)
        {
            Friendslist Friendslist1 = new Friendslist();
            Friendslist[] req = new Friendslist[202];

            IEnumerable<Friendslist> friend = utOfWork.FriendslistRepository.GetMany(p => p.idFriend == idUser);
            foreach (Friendslist a in friend.ToList())
            {


                if (a.idUser == idfriend)
                {
                    a.friend = true;
                   a.request = false;
                    utOfWork.FriendslistRepository.Update(a);
                    utOfWork.Commit();
                }
            }
        
        }


        public void denyfriend(int idFriend, int idUser)
        {
             Friendslist Friendslist1 = new Friendslist();
            Friendslist[] req = new Friendslist[202];

            IEnumerable<Friendslist> friend = utOfWork.FriendslistRepository.GetMany(p => p.idFriend == idUser);
            foreach (Friendslist a in friend.ToList())
            {


                if (a.idUser == idFriend)
                {
                    
                   a.request = false;
                    utOfWork.FriendslistRepository.Update(a);
                    utOfWork.Commit();
                }
            }
        
        }

        public void deletefriend(int idfriend, int iduser){


             Friendslist Friendslist1 = new Friendslist();
            Friendslist[] req = new Friendslist[202];

            IEnumerable<Friendslist> friend = utOfWork.FriendslistRepository.GetMany(p => p.idFriend == iduser);
            foreach (Friendslist a in friend.ToList())
            {


                if (a.idUser == idfriend)
                {
                    
                  
                    utOfWork.FriendslistRepository.Delete(a.id);
                    utOfWork.Commit();
                }
            }




        }




        public IEnumerable<user> listFriend(int idUser)
        {
            var testList = new List<user>();




            Friendslist[] req = new Friendslist[202];

            IEnumerable<Friendslist> friend = utOfWork.FriendslistRepository.GetMany(p => p.idFriend == idUser);




            foreach (Friendslist a in friend.ToList())
            {

                if (a.friend == true)
                {

                    testList.Add(utOfWork.UserRepository.Get(p => p.id == a.idUser));

                }
                else
                {



                }
            }

            return testList;
           
        }






       
        public void Dispose()
        {
            utOfWork.Dispose();
        }
    }
}
