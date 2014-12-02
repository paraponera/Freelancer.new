using Freelancer.Data.Infrastructure;
using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public class JobsServices : IJobsServices
    {

        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public JobsServices()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }


        public IEnumerable<job> GetJobs()
        {
            var jobs = utOfWork.JobRepository.GetAll();
            List<job> jj = jobs.ToList();



            return jobs;
        }


        public void AddService(job o)
        {
            utOfWork.JobRepository.Add(o);
            utOfWork.Commit();
        }
        public void UpdateJob(job o)
        {
            utOfWork.JobRepository.Update(o);
            utOfWork.Commit();
        }

        public job getJobbyid(int id)
        {
            var off = utOfWork.JobRepository.GetById(id);
            return off;
        }
        public void deleteJob(job o)
        {
            utOfWork.JobRepository.Delete(o);
            utOfWork.Commit();
        }

        public IEnumerable<job> GetJobByNom(string title)
        {
            return utOfWork.JobRepository.GetMany(p => p.title == title);
        }
        public IEnumerable<job> GetJobBycategory(string jobcategory)
        {
            return utOfWork.JobRepository.GetMany(p => p.description == jobcategory);
        }

        public void Dispose()
        {
            utOfWork.Dispose();
        }
    }
}