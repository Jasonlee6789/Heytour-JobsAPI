using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Service;
using WebApplication1.ResourceParameters;



namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/jobs")]
    public class HeytourController : Controller
    {
        private readonly IJobService _jobService;
        public HeytourController(IJobService jobService)
        {
            _jobService = jobService;
        }
        [HttpGet] //api/jobs
        public async Task<ActionResult<IEnumerable<HeytourJob>>> GetJobsList(
            //[FromQuery] JobsFilterParameters parameters
            )
        {
            _ = DateTime.TryParse(HttpContext.Request.Query["postedon"].ToString(), out DateTime postedOn);

            var filter = new JobsFilterParameters
            {
                IsActive = HttpContext.Request.Query["isActive"].ToString() == "true",
                PostedOn = postedOn,
                Title = HttpContext.Request.Query["title"].ToString()
            };

            var jobs = await _jobService.GetJobsList(filter);

            return jobs.ToList();
        }

        [HttpGet("{jobId}")] //api/jobs/jobId
        public async Task<ActionResult<HeytourJob>> GetJobById(int jobId)
        {
            var job = await _jobService.GetJobById(jobId);
            return job;
        }

        [HttpPost]
        public async Task<ActionResult<HeytourJob>> Post([FromBody] HeytourJob job)
        {
            var res = await _jobService.CreateJob(job);
            return res;
        }

        [HttpPut]
        [Route("{id}")]

        public async Task<ActionResult> PutJob(int id, [FromBody] HeytourJob job)
        {
            await _jobService.UpdateJob(id, job);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<ActionResult> DeleteJob(int id)
        {
            await _jobService.DeleteJob(id);

            return NoContent();
        }
    }

}
