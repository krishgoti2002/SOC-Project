using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    public class CandidateService : ICandidateService
    {
        //private List<Candidate> candidates;
        private AppDbContext appContext;
        public CandidateService()
        {
            this.appContext = new AppDbContext();
            //candidates = new List<Candidate>()
            //{
            //    new Candidate(){
            //        Id = 1,Name = "krish goti",Gender = "male",
            //        Email = "krishgoti@gmail.com",Mobile = "1234567890",
            //        Password = "krish123",
            //        CollageName = "Dharamsinh Desai University",
            //        DateOfBirth = new DateTime(2002,01,1),
            //        Skills = "Machine learning,React Native,React developer",
            //        PreferedJobLocations = "Surat,Vadodara,Canada",
            //        JobExperiences  = "2 years at google,2 years at amazon,3 years at ISRO" 
            //    },
            //    new Candidate(){
            //        Id = 2,Name = "yash kundalia",Gender = "male",
            //        Email = "yashkundalia@gmail.com",
            //        Password = "yash123",
            //        Mobile = "9876543210",
            //        CollageName = "Dharamsinh Desai University",
            //        DateOfBirth = new DateTime(2001,11,18),
            //        Skills = "Big Data Analysis,Android development,React developer",
            //        PreferedJobLocations = "Ahemdabad,Rajkot,Junagadh",
            //        JobExperiences  = "3 years at google,2 years at Microsoft,3 years at Tesla" 
            //    }
            //};
        }
        Candidate ICandidateService.AddCandidate(Candidate candidate)
        {
            appContext.Candidates.Add(candidate);
            appContext.SaveChanges();
            return candidate;
            //int id = candidates.Max(c => c.Id);
            //candidate.Id = id + 1;
            //candidates.Add(candidate);
            //return candidate;
        }

        List<Candidate> ICandidateService.GetAllCandidates()
        {
            return appContext.Candidates.ToList<Candidate>();
        }

        Candidate ICandidateService.GetCandidate(int id)
        {
            Candidate candidate =  appContext.Candidates.Where(x => x.Id == id).FirstOrDefault();
            return candidate;
            //Candidate candidate = null;
            //try
            //{
            //    candidate = candidates.Find(c => c.Id == id);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return candidate;
        }

        Candidate ICandidateService.RemoveCandidate(int id)
        {
            Candidate candidate = appContext.Candidates.Where(x => x.Id == id).FirstOrDefault();
            appContext.Candidates.Remove(candidate);
            appContext.SaveChanges();
            return candidate;
            //Candidate candidate = null;
            //try
            //{
            //    IEnumerable<Candidate> cand = candidates as IEnumerable<Candidate>;
            //    candidate = cand.Where(c => c.Id == id).FirstOrDefault();
            //    candidates.Remove(candidate);
                
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return candidate;
        }

        Candidate ICandidateService.UpdateCandidate(Candidate c)
        {
            Candidate candidate = (from x in appContext.Candidates
                          where x.Id == c.Id
                          select x).First();

            candidate.Name = c.Name;
            candidate.Gender = c.Gender;
            candidate.Mobile = c.Mobile;
            candidate.Email = c.Email;
            candidate.Password = c.Password;
            candidate.DateOfBirth = c.DateOfBirth;
            candidate.CollageName = c.CollageName;
            candidate.Skills = c.Skills;
            candidate.PreferedJobLocations = c.PreferedJobLocations;
            candidate.JobExperiences = c.JobExperiences;
            appContext.SaveChanges();

            return candidate;
            //try
            //{
            //    int i = candidates.FindIndex(c => c.Id == candidate.Id);
            //    candidates[i] = candidate;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return candidate;
        }
    }
}
