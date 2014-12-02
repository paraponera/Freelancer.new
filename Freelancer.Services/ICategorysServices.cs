using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public interface ICategorysServices : IDisposable
    {

        IEnumerable<category> GetCategorys();

        void AddService(category o);
        void UpdateCategory(category o);
        category getCategorybyid(int id);
        void deleteJob(category o);
    }
}
