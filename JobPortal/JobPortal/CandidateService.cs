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
        private List<Candidate> candidates;
        public CandidateService()
        {
            candidates = new List<Candidate>()
            {
                new Candidate(){
                    Id = 1,Name = "krish goti",Gender = "male",
                    Email = "krishgoti@gmail.com",Mobile = "1234567890",
                    Password = "krish123",
                    CollageName = "Dharamsinh Desai University",
                    DateOfBirth = new DateTime(2002,01,1),
                    Skills = new List<string> {"Machine learning","React Native","React developer"},
                    PreferedJobLocations = new List<string> {"Surat","Vadodara","Canada"},
                    JobExperiences  = new List<string> {"2 years at google","2 years at amazon","3 years at ISRO" }
                },
                new Candidate(){
                    Id = 2,Name = "yash kundalia",Gender = "male",
                    Email = "yashkundalia@gmail.com",
                    Password = "yash123",
                    Mobile = "9876543210",
                    CollageName = "Dharamsinh Desai University",
                    DateOfBirth = new DateTime(2001,11,18),
                    Skills = new List<string> {"Big Data Analysis","Android development","React developer"},
                    PreferedJobLocations = new List<string> {"Ahemdabad","Rajkot","Junagadh"},
                    JobExperiences  = new List<string> {"3 years at google","2 years at Microsoft","3 years at Tesla" }
                },
                new Candidate(){
                    Id = 3,Name = "prince vanani",Gender = "male",
                    Email = "princevanani@gmail.com",Mobile = "1357986420",
                    Password = "prince123",
                    CollageName = "Dharamsinh Desai University",
                    DateOfBirth = new DateTime(2001,12,18),
                    Skills = new List<string> {".NET core","React developer"},
                    PreferedJobLocations = new List<string> {"Ahemdabad","Surat","Jamnagar"},
                    JobExperiences  = new List<string> {"3 years at starlink","2 years at creast","3 years at amazon" }
                }
            };
        }
        Candidate ICandidateService.AddCandidate(Candidate candidate)
        {
            int id = candidates.Max(c => c.Id);
            candidate.Id = id + 1;
            candidates.Add(candidate);
            return candidate;
        }

        List<Candidate> ICandidateService.GetAllCandidates()
        {
            return candidates;
        }

        Candidate ICandidateService.GetCandidate(int id)
        {
            Candidate candidate = null;
            try
            {
                candidate = candidates.Find(c => c.Id == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return candidate;
        }

        Candidate ICandidateService.RemoveCandidate(int id)
        {
            Candidate candidate = null;
            try
            {
                IEnumerable<Candidate> cand = candidates as IEnumerable<Candidate>;
                candidate = cand.Where(c => c.Id == id).FirstOrDefault();
                candidates.Remove(candidate);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return candidate;
        }

        Candidate ICandidateService.UpdateCandidate(Candidate candidate)
        {
            try
            {
                int i = candidates.FindIndex(c => c.Id == candidate.Id);
                candidates[i] = candidate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return candidate;
        }
    }
}
