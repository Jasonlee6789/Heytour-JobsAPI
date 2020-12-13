using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Repo;

namespace WebApplication1.Service
{
    public interface IJobService
    {
        Task<IEnumerable<Heytour>> GetJobsList();
    }
    public class JobService : IJobService
    {
        private readonly IJobRepo _jobRepo;

        public JobService(IJobRepo jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public async Task<IEnumerable<Heytour>> GetJobsList()
        {
            var jobs = await Task.Run(() => _jobRepo.GetJobs().ToList());
            return jobs;
        }

     
    }
    
}
