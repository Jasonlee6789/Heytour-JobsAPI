﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Repo;
using WebApplication1.ResourceParameters;

namespace WebApplication1.Service
{
    public interface IJobService
    {
        Task<IEnumerable<HeytourJob>> GetJobsList(JobsFilterParameters parameters);
        Task<HeytourJob> GetJobById(int jobId);

        Task<HeytourJob> CreateJob(HeytourJob job);

        Task UpdateJob(int id, HeytourJob job);
        Task DeleteJob(int id);
    }
    //构造函数注入常用于在服务构建上定义和获取服务依赖。如下
    //或者用于声明和获取服务对服务构造的依赖关系
    //如果要实现依赖注入就得调用依赖注入的接口来创建实例。
    public class JobService : IJobService
    {
        //将注入的依赖赋值给只读（readonly）的字段或属性
        //(为了防止在内部方法中意外地赋予其他值)。
        private readonly IJobRepo _jobRepo;
        //构造函数JobService将IJobRepo作为依赖注入到它的构造函数
        public JobService(IJobRepo jobRepo)
        {

            _jobRepo = jobRepo;
        }
        //然后在 GetJobsList方法内部使用这个依赖
        public async Task<IEnumerable<HeytourJob>> GetJobsList(JobsFilterParameters parameters)
        {
            /*IEnumerable<HeytourJob> jobs = null;
            if (parameters.IsActive.HasValue)
            {
               jobs = await Task.Run(() => _jobRepo.GetJobs().Where(x => x.IsActive == parameters.IsActive).ToList());
               
            }
            else if (parameters.PostedOn.HasValue)
            {
                jobs = await Task.Run(() => _jobRepo.GetJobs().Where(x => x.PostedOn == parameters.PostedOn).ToList());
            } 
            else 
            {
                jobs= await Task.Run(() => _jobRepo.GetJobs().ToList());
            }*/
            var jobs = await _jobRepo.GetJobs(parameters);
            return jobs;
        }

        //注释掉的这些方法是在client端做query
        public async Task<HeytourJob> GetJobById(int jobId)
        {
            // var job = await Task.Run(() => _jobRepo.GetJobs().FirstOrDefault(x => x.Id == jobId));
            var job = await _jobRepo.GetJobById(jobId);
            return job;
        }

        public async Task<HeytourJob> CreateJob(HeytourJob job)
        {
            var res = await _jobRepo.CreateJob(job);
            return res;
        }

        public async Task UpdateJob(int id, HeytourJob job)
        {
            job.Id = id;
            await _jobRepo.UpdateJob(job);
        }

        public async Task DeleteJob(int id)
        {
            await _jobRepo.DeleteJob(id);
        }
    }

}
