using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public interface IUsersServices
    {
        void AddService(user o);
        void UpdateUser(user o);
        user getUserbyid(int id);
        int Authentification(String login, String pwd);
        int FindByEmail(string email);
        statistique statistique();
    }
}
