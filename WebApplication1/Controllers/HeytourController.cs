using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Service;


namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/heytour")]
    public class HeytourController : Controller
    {
        private readonly IJobService _jobService;
        public HeytourController(IJobService jobService)
        {
            _jobService = jobService;
        }
        [HttpGet] //api/heytour
        public async Task<ActionResult<IEnumerable<Heytour>>> GetJobsList()
        {
            var jobs = await _jobService.GetJobsList();

            return jobs.ToList();
        }

        //  [HttpGet("{jobId}")] //api/heytour/jobId
        //  public async Task<ActionResult<IEnumerable<Heytour>>> GetJobById(int jobId)
        //         {
        //             var job = await _jobService.GetJobById(jobId);
        //             return new JsonResult(job);
        //         }

    }

}
