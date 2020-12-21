using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using WebApplication1.Repo;
using WebApplication1.Service;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.OpenApi.Models;
using System;


namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.���ڷ���ע��
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
        {
           options.AddDefaultPolicy(
           builder =>
           {
               builder.WithOrigins("*")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
           });
        }
                            );

            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IJobRepo, JobRepo>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Heytour-JobsAPI", Version = "v1" });
            });

            string connectionString = Configuration["ConnectionStrings:JobDbContext"];

            services.AddDbContext<JobDbContext>(options => options.UseSqlServer(connectionString));
                                                           // (Configuration.GetConnectionString("JobDbContext")));
                                                


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.��Ӧ�ó��������ܵ�������м����
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Heytour-JobsAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

         

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
