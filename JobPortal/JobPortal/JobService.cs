using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    class JobService : IJobService
    {
        private AppDbContext appContext;
        //private List<Job> jobs;
        public JobService()
        {
            this.appContext = new AppDbContext();
            //jobs = new List<Job>()
            //{
            //    new Job(){
            //        Id = 1,
            //        Title="SDE role",
            //        Description="Job Dis1",
            //        Email="test@test.com",
            //        MobileNo="9882598825",
            //        City="Seattle",
            //        State="Washington DC",
            //        Company="Microsoft",
            //        Date=new DateTime(2009,11,18),
            //        Experience="5+ exp",
  
            //    },
            //    new Job(){
            //        Id = 2,
            //        Title="SDE role",
            //        Description="Job Dis2",
            //        Email="test2@test.com",
            //        MobileNo="9882598825",
            //        City="Seattle",
            //        State="Washington DC",
            //        Company="Apple",
            //        Date=new DateTime(2009,11,18),
            //        Experience="15+ exp",

            //    },
            //    new Job(){
            //        Id = 3,
            //        Title="SDE role",
            //        Description="Job Dis3",
            //        Email="test3@test.com",
            //        MobileNo="9882598825",
            //        City="Seattle",
            //        State="Washington DC",
            //        Company="IBM",
            //        Date=new DateTime(2009,11,18),
            //        Experience="10+ exp",

            //    }
            //};
        }

        public Job AddJob(Job job)
        {
            appContext.Jobs.Add(job);
            appContext.SaveChanges();
            return job;
            //int id = jobs.Max(c => c.Id);
            //job.Id = id + 1;
            //jobs.Add(job);
            //return job;
        }

        public List<Job> GetAllJobs()
        {
            return appContext.Jobs.ToList();
            //return jobs;
        }

        public Job GetJob(int id)
        {
            return appContext.Jobs.Find(id);
            //Job job = null;
            //try
            //{
            //    job = jobs.Find(c => c.Id == id);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return job;
        }

        public Job RemoveJob(int id)
        {
            Job job = appContext.Jobs.Find(id);
            appContext.Jobs.Remove(job);
            appContext.SaveChanges();
            return job;
            //Job job = null;
            //try
            //{
            //    IEnumerable<Job> temp = jobs as IEnumerable<Job>;
            //    job = temp.Where(c => c.Id == id).FirstOrDefault();
            //    jobs.Remove(job);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return job;
        }

        public Job UpdateJob(Job j)
        {
            Job job = (from x in appContext.Jobs where x.Id == j.Id select x).First();

            job.Title = j.Title;
            job.Description = j.Description;
            job.Email = j.Email;
            job.MobileNo = j.MobileNo;
            job.City = j.City;
            job.State = j.State;
            job.Company = j.Company;
            job.Date = j.Date;
            job.Experience = j.Experience;
            
            appContext.SaveChanges();
            return job;
            //try
            //{
            //    int i = jobs.FindIndex(c => c.Id == job.Id);
            //    jobs[i] = job;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return job;
        }
    }
}
