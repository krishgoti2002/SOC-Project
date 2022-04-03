using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    [DataContract]
    public class Candidate
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string Name { get; set; }
        /*
            0 - Male
            1 - Female
            2 - Others
         */
        [DataMember]
        [Required]
        public string Gender { get; set; }

        [DataMember]
        [Required]
        public string Email { get; set; }

        [DataMember]
        [Required]
        public string Mobile { get; set; }

        [DataMember]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        [Required]
        public string Password { get; set; }

        [DataMember]
        public string CollageName { get; set; }

        [DataMember]
        public string Skills { get; set; }

        [DataMember]
        public string PreferedJobLocations { get; set; }

        [DataMember]
        public string JobExperiences { get; set; }

        public Candidate()
        {
        }
    }
}
