using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
   public interface IFriendlistService:IDisposable
    {
       IEnumerable<user> listRequest(int idUser);
       void acceptfriend(int idFriend, int idUser);
       IEnumerable<user> listFriend(int idUser);
       void denyfriend(int idFriend, int idUser);
       void deletefriend(int idfriend, int iduser);
    }
}
