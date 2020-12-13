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
        [Route("api/GetJobList")]
        public class HeytourController : Controller
        {
            private readonly IJobService _jobService;
            public HeytourController(IJobService jobService)
            {
                _jobService = jobService;
            }
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Heytour>>> GetJobs()
            {
                var jobs = await _jobService.GetJobs();

                return jobs.ToList();
            }
        }

}
