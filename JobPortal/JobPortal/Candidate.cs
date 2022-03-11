using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    [DataContract]
    public class Candidate
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        /*
            0 - Male
            1 - Female
            2 - Others
         */
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string CollageName { get; set; }
        [DataMember]
        public List<string> Skills { get; set; }
        [DataMember]
        public List<string> PreferedJobLocations { get; set; }
        [DataMember]
        public List<string> JobExperiences { get; set; }
        public Candidate()
        {
        }
    }
}
