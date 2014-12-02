using Freelancer.Data.Infrastructure;
using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public class CategorysServices : ICategorysServices
    {

        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public CategorysServices()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }


        public IEnumerable<category> GetCategorys()
        {
            var categorys = utOfWork.CategoryRepository.GetAll();
            return categorys;
        }


        public void AddService(category o)
        {
            utOfWork.CategoryRepository.Add(o);
            utOfWork.Commit();
        }
        public void UpdateJob(category o)
        {
            utOfWork.CategoryRepository.Update(o);
            utOfWork.Commit();
        }

        public category getCategorybyid(int id)
        {
            var cat = utOfWork.CategoryRepository.GetById(id);
            return cat;
        }
        public void deleteJob(category o)
        {
            utOfWork.CategoryRepository.Delete(o);
            utOfWork.Commit();
        }


        public void UpdateCategory(category o)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            utOfWork.Dispose();
        }
    }
}
