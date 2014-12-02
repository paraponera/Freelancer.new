using Freelancer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    public interface IJobsServices : IDisposable
    {
        IEnumerable<job> GetJobs();

        void AddService(job o);
        void UpdateJob(job o);
        job getJobbyid(int id);
        void deleteJob(job o);
        IEnumerable<job> GetJobByNom(string title);
        IEnumerable<job> GetJobBycategory(string jobcategory);
    }
}
